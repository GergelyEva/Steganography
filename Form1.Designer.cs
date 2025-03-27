namespace Steganography
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      textBoxFilePath = new TextBox();
      pictureBox1 = new PictureBox();
      txtDecrypted = new TextBox();
      p1text = new TextBox();
      txtNumberA = new NumericUpDown();
      txtNumberB = new NumericUpDown();
      btnExchange = new MaterialSkin.Controls.MaterialButton();
      buttonOpenFile = new MaterialSkin.Controls.MaterialButton();
      Encode = new MaterialSkin.Controls.MaterialButton();
      btnDecrypt = new MaterialSkin.Controls.MaterialButton();
      pictureBox2 = new PictureBox();
      nrA = new MaterialSkin.Controls.MaterialLabel();
      nrB = new MaterialSkin.Controls.MaterialLabel();
      label1 = new MaterialSkin.Controls.MaterialLabel();
      label2 = new MaterialSkin.Controls.MaterialLabel();
      label3 = new MaterialSkin.Controls.MaterialLabel();
      lblText = new MaterialSkin.Controls.MaterialLabel();
      lblDecryptedMessage = new MaterialSkin.Controls.MaterialLabel();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)txtNumberA).BeginInit();
      ((System.ComponentModel.ISupportInitialize)txtNumberB).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      SuspendLayout();
      // 
      // textBoxFilePath
      // 
      textBoxFilePath.Location = new Point(632, 58);
      textBoxFilePath.Name = "textBoxFilePath";
      textBoxFilePath.Size = new Size(269, 27);
      textBoxFilePath.TabIndex = 22;
      // 
      // pictureBox1
      // 
      pictureBox1.Location = new Point(632, 103);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(837, 343);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 21;
      pictureBox1.TabStop = false;
      // 
      // txtDecrypted
      // 
      txtDecrypted.Location = new Point(312, 340);
      txtDecrypted.Multiline = true;
      txtDecrypted.Name = "txtDecrypted";
      txtDecrypted.Size = new Size(220, 386);
      txtDecrypted.TabIndex = 18;
      // 
      // p1text
      // 
      p1text.Location = new Point(34, 340);
      p1text.Multiline = true;
      p1text.Name = "p1text";
      p1text.Size = new Size(216, 386);
      p1text.TabIndex = 13;
      // 
      // txtNumberA
      // 
      txtNumberA.Location = new Point(230, 53);
      txtNumberA.Name = "txtNumberA";
      txtNumberA.Size = new Size(150, 27);
      txtNumberA.TabIndex = 29;
      // 
      // txtNumberB
      // 
      txtNumberB.Location = new Point(230, 116);
      txtNumberB.Name = "txtNumberB";
      txtNumberB.Size = new Size(150, 27);
      txtNumberB.TabIndex = 30;
      // 
      // btnExchange
      // 
      btnExchange.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      btnExchange.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      btnExchange.Depth = 0;
      btnExchange.HighEmphasis = true;
      btnExchange.Icon = null;
      btnExchange.Location = new Point(436, 79);
      btnExchange.Margin = new Padding(4, 6, 4, 6);
      btnExchange.MouseState = MaterialSkin.MouseState.HOVER;
      btnExchange.Name = "btnExchange";
      btnExchange.NoAccentTextColor = Color.Empty;
      btnExchange.Size = new Size(137, 36);
      btnExchange.TabIndex = 33;
      btnExchange.Text = "Exchange keys";
      btnExchange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      btnExchange.UseAccentColor = false;
      btnExchange.UseVisualStyleBackColor = true;
      btnExchange.Click += btnExchange_Click;
      // 
      // buttonOpenFile
      // 
      buttonOpenFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      buttonOpenFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      buttonOpenFile.Depth = 0;
      buttonOpenFile.HighEmphasis = true;
      buttonOpenFile.Icon = null;
      buttonOpenFile.Location = new Point(934, 58);
      buttonOpenFile.Margin = new Padding(4, 6, 4, 6);
      buttonOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
      buttonOpenFile.Name = "buttonOpenFile";
      buttonOpenFile.NoAccentTextColor = Color.Empty;
      buttonOpenFile.Size = new Size(92, 36);
      buttonOpenFile.TabIndex = 34;
      buttonOpenFile.Text = "Open File";
      buttonOpenFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      buttonOpenFile.UseAccentColor = false;
      buttonOpenFile.UseVisualStyleBackColor = true;
      buttonOpenFile.Click += buttonOpenFile_Click;
      // 
      // Encode
      // 
      Encode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      Encode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      Encode.Depth = 0;
      Encode.HighEmphasis = true;
      Encode.Icon = null;
      Encode.Location = new Point(96, 749);
      Encode.Margin = new Padding(4, 6, 4, 6);
      Encode.MouseState = MaterialSkin.MouseState.HOVER;
      Encode.Name = "Encode";
      Encode.NoAccentTextColor = Color.Empty;
      Encode.Size = new Size(64, 36);
      Encode.TabIndex = 35;
      Encode.Text = "Send";
      Encode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      Encode.UseAccentColor = false;
      Encode.UseVisualStyleBackColor = true;
      Encode.Click += Encode_Click;
      // 
      // btnDecrypt
      // 
      btnDecrypt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      btnDecrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      btnDecrypt.Depth = 0;
      btnDecrypt.HighEmphasis = true;
      btnDecrypt.Icon = null;
      btnDecrypt.Location = new Point(383, 749);
      btnDecrypt.Margin = new Padding(4, 6, 4, 6);
      btnDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
      btnDecrypt.Name = "btnDecrypt";
      btnDecrypt.NoAccentTextColor = Color.Empty;
      btnDecrypt.Size = new Size(85, 36);
      btnDecrypt.TabIndex = 36;
      btnDecrypt.Text = "Decrypt";
      btnDecrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      btnDecrypt.UseAccentColor = false;
      btnDecrypt.UseVisualStyleBackColor = true;
      btnDecrypt.Click += btnDecrypt_Click;
      // 
      // pictureBox2
      // 
      pictureBox2.Location = new Point(632, 502);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(837, 343);
      pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox2.TabIndex = 37;
      pictureBox2.TabStop = false;
      // 
      // nrA
      // 
      nrA.AutoSize = true;
      nrA.Depth = 0;
      nrA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      nrA.Location = new Point(61, 53);
      nrA.MouseState = MaterialSkin.MouseState.HOVER;
      nrA.Name = "nrA";
      nrA.Size = new Size(99, 19);
      nrA.TabIndex = 38;
      nrA.Text = "Number for A:";
      // 
      // nrB
      // 
      nrB.AutoSize = true;
      nrB.Depth = 0;
      nrB.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      nrB.Location = new Point(61, 124);
      nrB.MouseState = MaterialSkin.MouseState.HOVER;
      nrB.Name = "nrB";
      nrB.Size = new Size(99, 19);
      nrB.TabIndex = 39;
      nrB.Text = "Number for B:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Depth = 0;
      label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      label1.Location = new Point(67, 165);
      label1.MouseState = MaterialSkin.MouseState.HOVER;
      label1.Name = "label1";
      label1.Size = new Size(15, 19);
      label1.TabIndex = 40;
      label1.Text = "A:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Depth = 0;
      label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      label2.Location = new Point(67, 198);
      label2.MouseState = MaterialSkin.MouseState.HOVER;
      label2.Name = "label2";
      label2.Size = new Size(15, 19);
      label2.TabIndex = 41;
      label2.Text = "B:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Depth = 0;
      label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      label3.Location = new Point(67, 247);
      label3.MouseState = MaterialSkin.MouseState.HOVER;
      label3.Name = "label3";
      label3.Size = new Size(83, 19);
      label3.TabIndex = 42;
      label3.Text = "Shared key:";
      // 
      // lblText
      // 
      lblText.AutoSize = true;
      lblText.Depth = 0;
      lblText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      lblText.Location = new Point(67, 309);
      lblText.MouseState = MaterialSkin.MouseState.HOVER;
      lblText.Name = "lblText";
      lblText.Size = new Size(143, 19);
      lblText.TabIndex = 43;
      lblText.Text = "Message to encrypt:";
      // 
      // lblDecryptedMessage
      // 
      lblDecryptedMessage.AutoSize = true;
      lblDecryptedMessage.Depth = 0;
      lblDecryptedMessage.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
      lblDecryptedMessage.Location = new Point(383, 309);
      lblDecryptedMessage.MouseState = MaterialSkin.MouseState.HOVER;
      lblDecryptedMessage.Name = "lblDecryptedMessage";
      lblDecryptedMessage.Size = new Size(76, 19);
      lblDecryptedMessage.TabIndex = 44;
      lblDecryptedMessage.Text = "Decrypted:";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1479, 838);
      Controls.Add(lblDecryptedMessage);
      Controls.Add(lblText);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(nrB);
      Controls.Add(nrA);
      Controls.Add(pictureBox2);
      Controls.Add(btnDecrypt);
      Controls.Add(Encode);
      Controls.Add(buttonOpenFile);
      Controls.Add(btnExchange);
      Controls.Add(txtNumberB);
      Controls.Add(txtNumberA);
      Controls.Add(textBoxFilePath);
      Controls.Add(pictureBox1);
      Controls.Add(txtDecrypted);
      Controls.Add(p1text);
      Name = "Form1";
      Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ((System.ComponentModel.ISupportInitialize)txtNumberA).EndInit();
      ((System.ComponentModel.ISupportInitialize)txtNumberB).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBoxFilePath;
    private PictureBox pictureBox1;
    private TextBox txtDecrypted;
    private TextBox p1text;
    private NumericUpDown txtNumberA;
    private NumericUpDown txtNumberB;
    private MaterialSkin.Controls.MaterialButton btnExchange;
    private MaterialSkin.Controls.MaterialButton buttonOpenFile;
    private MaterialSkin.Controls.MaterialButton Encode;
    private MaterialSkin.Controls.MaterialButton btnDecrypt;
    private PictureBox pictureBox2;
    private MaterialSkin.Controls.MaterialLabel nrA;
    private MaterialSkin.Controls.MaterialLabel nrB;
    private MaterialSkin.Controls.MaterialLabel label1;
    private MaterialSkin.Controls.MaterialLabel label2;
    private MaterialSkin.Controls.MaterialLabel label3;
    private MaterialSkin.Controls.MaterialLabel lblText;
    private MaterialSkin.Controls.MaterialLabel lblDecryptedMessage;
  }
}
