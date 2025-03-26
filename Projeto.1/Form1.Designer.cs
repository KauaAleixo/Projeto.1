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
            pictureBox2 = new PictureBox();
            btnRegistrar = new Button();
            txtConfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            Login = new TabPage();
            imgPicture1 = new PictureBox();
            btnLogin = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            Banco = new TabPage();
            Configuraçoes = new TabPage();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPicture1).BeginInit();
            tabControl1.SuspendLayout();
            Banco.SuspendLayout();
            Configuraçoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            Registro.Size = new Size(795, 423);
            Registro.TabIndex = 1;
            Registro.Text = "Registro";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
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
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Gainsboro;
            btnRegistrar.Location = new Point(168, 233);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 28);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = SystemColors.Info;
            txtConfirmarSenha.Location = new Point(168, 185);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(115, 23);
            txtConfirmarSenha.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Info;
            txtSenha.Location = new Point(168, 147);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(115, 23);
            txtSenha.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Location = new Point(168, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(115, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 104);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Usuário";
            // 
            // Login
            // 
            Login.Controls.Add(imgPicture1);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(txtSenhaLogin);
            Login.Controls.Add(txtUsuarioLogin);
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Location = new Point(4, 24);
            Login.Name = "Login";
            Login.Padding = new Padding(3);
            Login.Size = new Size(795, 423);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // imgPicture1
            // 
            imgPicture1.BackgroundImage = (Image)resources.GetObject("imgPicture1.BackgroundImage");
            imgPicture1.BackgroundImageLayout = ImageLayout.Stretch;
            imgPicture1.Location = new Point(422, 124);
            imgPicture1.Name = "imgPicture1";
            imgPicture1.Size = new Size(100, 95);
            imgPicture1.TabIndex = 5;
            imgPicture1.TabStop = false;
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
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = SystemColors.Info;
            txtSenhaLogin.Location = new Point(159, 178);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(115, 23);
            txtSenhaLogin.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(Login);
            tabControl1.Controls.Add(Registro);
            tabControl1.Controls.Add(Banco);
            tabControl1.Controls.Add(Configuraçoes);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 451);
            tabControl1.TabIndex = 0;
            // 
            // Banco
            // 
            Banco.Controls.Add(dataGridView1);
            Banco.Location = new Point(4, 24);
            Banco.Name = "Banco";
            Banco.Size = new Size(795, 423);
            Banco.TabIndex = 2;
            Banco.Text = "Banco";
            Banco.UseVisualStyleBackColor = true;
            // 
            // Configuraçoes
            // 
            Configuraçoes.Controls.Add(domainUpDown1);
            Configuraçoes.Controls.Add(textBox3);
            Configuraçoes.Controls.Add(textBox2);
            Configuraçoes.Controls.Add(textBox1);
            Configuraçoes.Controls.Add(label9);
            Configuraçoes.Controls.Add(label8);
            Configuraçoes.Controls.Add(label7);
            Configuraçoes.Controls.Add(label4);
            Configuraçoes.Location = new Point(4, 24);
            Configuraçoes.Name = "Configuraçoes";
            Configuraçoes.Size = new Size(795, 423);
            Configuraçoes.TabIndex = 3;
            Configuraçoes.Text = "Configurações";
            Configuraçoes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Senha, Email });
            dataGridView1.Location = new Point(89, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 287);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Senha
            // 
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 95);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 2;
            label4.Text = "Endereço SMTP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(177, 146);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 3;
            label7.Text = "Porta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(177, 196);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 2;
            label8.Text = "E-mail do Usuário";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(177, 247);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 4;
            label9.Text = "Senha do E-mail";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(326, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(326, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(326, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(115, 23);
            textBox3.TabIndex = 8;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(326, 146);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)imgPicture1).EndInit();
            tabControl1.ResumeLayout(false);
            Banco.ResumeLayout(false);
            Configuraçoes.ResumeLayout(false);
            Configuraçoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private PictureBox imgPicture1;
        private Button btnLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        public BindingSource bindingSource1;
        private TabPage Banco;
        private TabPage Configuraçoes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Email;
        private DomainUpDown domainUpDown1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
    }
}
