using System.Text;
using System.Numerics;
using System.Security.Cryptography;

namespace Steganography
{
  public partial class Form1 : Form
  {
    private int p, g, a, b, A, B;

    private byte[] sharedKey;

    string newFileName = "";
    Random rnd = new Random();

    public Form1()
    {
      InitializeComponent();
      p = 23;
      g = 5;
      a = rnd.Next(0, 255);
      b = rnd.Next(0, 255);
      txtNumberA.Text = a.ToString();
      txtNumberB.Text = b.ToString();
      //btnExchange.Enabled = true;
      buttonOpenFile.Enabled = false;
      Encode.Enabled = false;
      btnDecrypt.Enabled = false;
    }

    private void btnExchange_Click(object sender, EventArgs e)
    { //se citesc cheile publice
      a = Convert.ToInt32(txtNumberA.Value);
      b = Convert.ToInt32(txtNumberB.Value);
      InitializePerson1();
    }

    private void InitializePerson1()
    {
      A = (int)BigInteger.ModPow(g, a, p);
      label1.Text = $"Number: {a}  A (public key): {A}";

      InitializePerson2(A);
    }

    private void InitializePerson2(int pkA)
    {
      B = (int)BigInteger.ModPow(g, b, p);
      label2.Text = $"Number: {b}  B (public key): {B}";

      VerifyPersons(pkA, B);
    }

    private string GenerateHMAC(int data)
    {
      HMACSHA256 hmac = new HMACSHA256(sharedKey); //un hmac nou, semnat cu cheia comuna
      byte[] dataBytes = BitConverter.GetBytes(data);//conversie in bytes
      byte[] hash = hmac.ComputeHash(dataBytes);//creare de hash din cele sharedkey si date.
      string hashString = Convert.ToBase64String(hash);// criptat, transformat in string 
      hmac.Dispose();
      return hashString;
    }

    private bool VerifyHMAC(int data, string Hmac)
    {
      string newHMAC = GenerateHMAC(data);//creeaza un hmac nou
      return newHMAC == Hmac;//verifica daca sunt aceeasi
    }

    private void VerifyPersons(int pkA, int pkB)
    {

      //se calculeaza B^a mod pow si A^b mod pow
      int privateKeyB = (int)BigInteger.ModPow(pkB, a, p);
      int privateKeyA = (int)BigInteger.ModPow(pkA, b, p);

      if (privateKeyB == privateKeyA)
      {//daca cele doua sunt egale
        sharedKey = BitConverter.GetBytes(privateKeyB);//conversie in bytes pentru hmac (little endian)
        string byteArrayToString = BitConverter.ToString(sharedKey);
        //conversia de sharedkey byte in string pentru afisare/verificare 

        label3.Text = "Shared secret is: " + privateKeyB;
        MessageBox.Show("sharedkey", byteArrayToString);
      }

      string hmacA = GenerateHMAC(pkA);
      string hmacB = GenerateHMAC(pkB);

      if (!VerifyHMAC(pkA, hmacA) || !VerifyHMAC(pkB, hmacB))
      {
        MessageBox.Show("HMAC verification failed");
        return;
      }

      label3.Text += "\n HMAC verified";
      buttonOpenFile.Enabled = true;
    }

    private void buttonOpenFile_Click(object sender, EventArgs e)
    {//se deschide fisierul si se alege poza
      OpenFileDialog openDialog = new OpenFileDialog();
      openDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
      openDialog.InitialDirectory = @"C:\Users\HP\source\repos\SteganographyWithDiffieHellman";

      if (openDialog.ShowDialog() == DialogResult.OK)
      {
        textBoxFilePath.Text = openDialog.FileName.ToString();
        pictureBox1.ImageLocation = textBoxFilePath.Text;
      }
      Encode.Enabled = true;
    }

    private void Encode_Click(object sender, EventArgs e)
    {
      string messageFromTextBox = p1text.Text;//textul de ascuns in poza

      byte[] messageBytes = Encoding.UTF8.GetBytes(messageFromTextBox);//conversie in bytes
      int messageLength = messageBytes.Length; //lungimea mesajului ascuns in bytes

      Bitmap img = new Bitmap(textBoxFilePath.Text);//creeare o noua imagine bitmap pentru manipulare pixeli

      Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);//preia ultimul pixel din imagine, unde vom ascunde mesajul
      //ascundere mesaj in ultimul pixel: Rosu ramane neschimbat, Green - MSB, shiftat cu 8 la dreapta, Blue- aici pune LSB
      img.SetPixel(img.Width - 1, img.Height - 1,
                   Color.FromArgb(lastPixel.R,
                                 (messageLength >> 8) & 0xFF,
                                 messageLength & 0xFF));

      int keyIndex = 0;//pentru locatia cheii
      int x = 0, y = 0;//pentru iterare prin imagine

      for (int i = 0; i < messageBytes.Length; i++)
      {//se stocheaza o parte din informatie in fiecare pixel albastru
        byte transformedByte = (byte)(messageBytes[i] ^ sharedKey[keyIndex]);//encriptie xor
        //byte transformedByte = messageBytes[i]; //fata encriptie xor

        Color pixel = img.GetPixel(x, y);//se ia pixelul

        img.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, transformedByte));//se seteaza doar Blue

        y++;
        if (y >= img.Height)//pentru parcurgere pixeli
        {
          y = 0;
          x++;
        }

        keyIndex = (keyIndex + 1) % sharedKey.Length;//daca mesajul are mai multi bytes decat cheia
        // cand s-au parcurs valorile din cheie, incepe de la [0]
      }

      SaveFileDialog saveFile = new SaveFileDialog();
      saveFile.Filter = "PNG Image (*.png)|*.png";
      saveFile.DefaultExt = "png";
      saveFile.AddExtension = true;

      if (saveFile.ShowDialog() == DialogResult.OK)
      {
        textBoxFilePath.Text = saveFile.FileName.ToString();
        pictureBox2.ImageLocation = textBoxFilePath.Text;
        string fileName = saveFile.FileName;
        if (!fileName.ToLower().EndsWith(".png"))
        {
          fileName += ".png";
        }
        newFileName = fileName;
        img.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
      }

      btnDecrypt.Enabled = true;
    }

    private void btnDecrypt_Click(object sender, EventArgs e)
    {
      if (!textBoxFilePath.Text.ToLower().EndsWith(".png"))
      {
        MessageBox.Show("Select png file.");
        return;
      }

      Bitmap img = new Bitmap(newFileName);

      Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);//preia ultimul pixel unde este stocat dimensiunea mesajului
      int msgLength = (lastPixel.G << 8) | lastPixel.B;//se shifteaza pxelul Green cu 8, dupa care se face OR cu Blue, astfel se obtine mesajul

      if (msgLength <= 0 || msgLength > img.Width * img.Height)
      {
        MessageBox.Show("Select png file.");
        return;
      }

      byte[] extractedBytes = new byte[msgLength];//initializare array the bytes nou cu dimensiunea mesajului
      int x = 0, y = 0;
      int keyIndex = 0;

      for (int i = 0; i < msgLength; i++)//se parcurge pana cand am ajuns la dimensiunea textului ascuns
      {
        Color pixel = img.GetPixel(x, y);
        byte transformedByte = (byte)pixel.B;//ne intereseaza doar pixelul albastru unde este stocat mesajul

        extractedBytes[i] = (byte)(transformedByte ^ sharedKey[keyIndex]);//inca un xor, pentru a reface byte-ul original

        y++;
        if (y >= img.Height)
        {
          y = 0;
          x++;
        }
        keyIndex = (keyIndex + 1) % sharedKey.Length;
      }

      string originalMessage = Encoding.UTF8.GetString(extractedBytes);
      txtDecrypted.Text = originalMessage;

    }

  }
}