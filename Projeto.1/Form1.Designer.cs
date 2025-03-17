namespace Projeto._1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bindingSource1 = new BindingSource(components);
            Registro = new TabPage();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnRegistrar = new Button();
            pictureBox2 = new PictureBox();
            Login = new TabPage();
            label1 = new Label();
            label2 = new Label();
            txtUsuarioLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Registro
            // 
            Registro.Controls.Add(pictureBox2);
            Registro.Controls.Add(btnRegistrar);
            Registro.Controls.Add(txtConfirmarSenha);
            Registro.Controls.Add(txtSenha);
            Registro.Controls.Add(txtUsuario);
            Registro.Controls.Add(label6);
            Registro.Controls.Add(label5);
            Registro.Controls.Add(label3);
            Registro.Location = new Point(4, 24);
            Registro.Name = "Registro";
            Registro.Padding = new Padding(3);
            Registro.Size = new Size(627, 422);
            Registro.TabIndex = 1;
            Registro.Text = "Registro";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 104);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 185);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Confirmar";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 147);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Location = new Point(168, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(115, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Info;
            txtSenha.Location = new Point(168, 147);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(115, 23);
            txtSenha.TabIndex = 6;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = SystemColors.Info;
            txtConfirmarSenha.Location = new Point(168, 185);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(115, 23);
            txtConfirmarSenha.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Gainsboro;
            btnRegistrar.Location = new Point(168, 233);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 28);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Login";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(440, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            Login.Controls.Add(pictureBox1);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(txtSenhaLogin);
            Login.Controls.Add(txtUsuarioLogin);
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Location = new Point(4, 24);
            Login.Name = "Login";
            Login.Padding = new Padding(3);
            Login.Size = new Size(627, 422);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 124);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = SystemColors.Info;
            txtUsuarioLogin.Location = new Point(159, 124);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(115, 23);
            txtUsuarioLogin.TabIndex = 2;
            txtUsuarioLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = SystemColors.Info;
            txtSenhaLogin.Location = new Point(159, 178);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(115, 23);
            txtSenhaLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.Location = new Point(159, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(422, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Login);
            tabControl1.Controls.Add(Registro);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(635, 450);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            Registro.ResumeLayout(false);
            Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private TabPage Registro;
        private PictureBox pictureBox2;
        private Button btnRegistrar;
        private TextBox txtConfirmarSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label6;
        private Label label5;
        private Label label3;
        private TabPage Login;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
    }
}
