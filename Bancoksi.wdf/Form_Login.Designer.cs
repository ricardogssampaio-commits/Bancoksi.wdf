namespace Bancoksi.wdf
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            pictureBox1 = new PictureBox();
            linkLabel_Esqueceu_a_senha = new LinkLabel();
            textBox_Login_Utilizador = new TextBox();
            textBox_Login_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Entrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(280, 100);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // linkLabel_Esqueceu_a_senha
            // 
            linkLabel_Esqueceu_a_senha.AutoSize = true;
            linkLabel_Esqueceu_a_senha.LinkColor = Color.Black;
            linkLabel_Esqueceu_a_senha.Location = new Point(14, 568);
            linkLabel_Esqueceu_a_senha.Name = "linkLabel_Esqueceu_a_senha";
            linkLabel_Esqueceu_a_senha.Size = new Size(132, 20);
            linkLabel_Esqueceu_a_senha.TabIndex = 10;
            linkLabel_Esqueceu_a_senha.TabStop = true;
            linkLabel_Esqueceu_a_senha.Text = "Esqueceu a senha?";
            // 
            // textBox_Login_Utilizador
            // 
            textBox_Login_Utilizador.Location = new Point(362, 336);
            textBox_Login_Utilizador.Margin = new Padding(3, 4, 3, 4);
            textBox_Login_Utilizador.Name = "textBox_Login_Utilizador";
            textBox_Login_Utilizador.Size = new Size(172, 27);
            textBox_Login_Utilizador.TabIndex = 11;
            // 
            // textBox_Login_Password
            // 
            textBox_Login_Password.Location = new Point(362, 397);
            textBox_Login_Password.Margin = new Padding(3, 4, 3, 4);
            textBox_Login_Password.Name = "textBox_Login_Password";
            textBox_Login_Password.Size = new Size(172, 27);
            textBox_Login_Password.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 312);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 373);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // button_Entrar
            // 
            button_Entrar.BackColor = Color.DodgerBlue;
            button_Entrar.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Entrar.ForeColor = SystemColors.ControlLightLight;
            button_Entrar.Location = new Point(355, 436);
            button_Entrar.Margin = new Padding(3, 4, 3, 4);
            button_Entrar.Name = "button_Entrar";
            button_Entrar.Size = new Size(179, 40);
            button_Entrar.TabIndex = 15;
            button_Entrar.Text = "Entrar";
            button_Entrar.UseVisualStyleBackColor = false;
            button_Entrar.Click += button_Entrar_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(button_Entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Login_Password);
            Controls.Add(textBox_Login_Utilizador);
            Controls.Add(linkLabel_Esqueceu_a_senha);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Login";
            Text = "Form_login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel_Esqueceu_a_senha;
        private TextBox textBox_Login_Utilizador;
        private TextBox textBox_Login_Password;
        private Label label1;
        private Label label2;
        private Button button_Entrar;
    }
}