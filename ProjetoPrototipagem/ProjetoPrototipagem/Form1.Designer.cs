namespace ProjetoPrototipagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxPortas = new System.Windows.Forms.ComboBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.spSerial = new System.IO.Ports.SerialPort(this.components);
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEfeito2 = new System.Windows.Forms.Button();
            this.btnEfeito4 = new System.Windows.Forms.Button();
            this.btnEfeito3 = new System.Windows.Forms.Button();
            this.btnEfeito5 = new System.Windows.Forms.Button();
            this.btnEfeito1 = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPortas
            // 
            this.cbxPortas.BackColor = System.Drawing.Color.White;
            this.cbxPortas.FormattingEnabled = true;
            this.cbxPortas.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbxPortas.Location = new System.Drawing.Point(12, 27);
            this.cbxPortas.Name = "cbxPortas";
            this.cbxPortas.Size = new System.Drawing.Size(164, 21);
            this.cbxPortas.TabIndex = 5;
            this.cbxPortas.Text = "COM1";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(12, 66);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(164, 36);
            this.btnLigar.TabIndex = 6;
            this.btnLigar.Text = "Conectar Porta Serial";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // spSerial
            // 
            this.spSerial.BaudRate = 19200;
            this.spSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spSerial_DataReceived);
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "botao2.jpg");
            this.imageList.Images.SetKeyName(1, "botao4.jpeg");
            this.imageList.Images.SetKeyName(2, "imagembart.jpg");
            // 
            // btnEfeito2
            // 
            this.btnEfeito2.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.IMAGEM;
            this.btnEfeito2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfeito2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfeito2.Location = new System.Drawing.Point(354, 23);
            this.btnEfeito2.Name = "btnEfeito2";
            this.btnEfeito2.Size = new System.Drawing.Size(112, 101);
            this.btnEfeito2.TabIndex = 1;
            this.btnEfeito2.UseVisualStyleBackColor = true;
            this.btnEfeito2.Click += new System.EventHandler(this.btnEfeito2_Click);
            // 
            // btnEfeito4
            // 
            this.btnEfeito4.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.IMAGEM;
            this.btnEfeito4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfeito4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfeito4.Location = new System.Drawing.Point(199, 152);
            this.btnEfeito4.Name = "btnEfeito4";
            this.btnEfeito4.Size = new System.Drawing.Size(112, 103);
            this.btnEfeito4.TabIndex = 3;
            this.btnEfeito4.UseVisualStyleBackColor = true;
            this.btnEfeito4.Click += new System.EventHandler(this.btnEfeito4_Click);
            // 
            // btnEfeito3
            // 
            this.btnEfeito3.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.IMAGEM;
            this.btnEfeito3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfeito3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfeito3.Location = new System.Drawing.Point(38, 152);
            this.btnEfeito3.Name = "btnEfeito3";
            this.btnEfeito3.Size = new System.Drawing.Size(112, 101);
            this.btnEfeito3.TabIndex = 2;
            this.btnEfeito3.UseVisualStyleBackColor = true;
            this.btnEfeito3.Click += new System.EventHandler(this.btnEfeito3_Click);
            // 
            // btnEfeito5
            // 
            this.btnEfeito5.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.IMAGEM;
            this.btnEfeito5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfeito5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfeito5.Location = new System.Drawing.Point(354, 152);
            this.btnEfeito5.Name = "btnEfeito5";
            this.btnEfeito5.Size = new System.Drawing.Size(112, 103);
            this.btnEfeito5.TabIndex = 4;
            this.btnEfeito5.UseVisualStyleBackColor = true;
            this.btnEfeito5.Click += new System.EventHandler(this.btnEfeito5_Click);
            // 
            // btnEfeito1
            // 
            this.btnEfeito1.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.IMAGEM;
            this.btnEfeito1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfeito1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfeito1.Location = new System.Drawing.Point(199, 23);
            this.btnEfeito1.Name = "btnEfeito1";
            this.btnEfeito1.Size = new System.Drawing.Size(112, 101);
            this.btnEfeito1.TabIndex = 0;
            this.btnEfeito1.UseVisualStyleBackColor = true;
            this.btnEfeito1.Click += new System.EventHandler(this.btnEfeito1_Click);
            // 
            // pb3
            // 
            this.pb3.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.imagembart;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(38, 152);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(112, 103);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.imagembart;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(354, 23);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(112, 103);
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            // 
            // pb4
            // 
            this.pb4.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.imagembart;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(199, 152);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(112, 103);
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            this.pb4.Visible = false;
            // 
            // pb5
            // 
            this.pb5.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.imagembart;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(354, 152);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(112, 103);
            this.pb5.TabIndex = 10;
            this.pb5.TabStop = false;
            this.pb5.Visible = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.imagembart;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(199, 23);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(112, 103);
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPrototipagem.Properties.Resources.spingfield;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 282);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.btnEfeito5);
            this.Controls.Add(this.btnEfeito1);
            this.Controls.Add(this.btnEfeito4);
            this.Controls.Add(this.btnEfeito3);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.cbxPortas);
            this.Controls.Add(this.btnEfeito2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Botões com Efeitos no Arduino";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxPortas;
        private System.Windows.Forms.Button btnLigar;
        private System.IO.Ports.SerialPort spSerial;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnEfeito2;
        private System.Windows.Forms.Button btnEfeito4;
        private System.Windows.Forms.Button btnEfeito3;
        private System.Windows.Forms.Button btnEfeito5;
        private System.Windows.Forms.Button btnEfeito1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb1;
    }
}

