namespace LoginSystem
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Linha1 = new System.Windows.Forms.Panel();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.Linha2 = new System.Windows.Forms.Panel();
            this.tituloTelaLogin = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.iconeOlhoAberto = new System.Windows.Forms.PictureBox();
            this.iconeOlhoFechado = new System.Windows.Forms.PictureBox();
            this.inputRepitaSenha = new System.Windows.Forms.TextBox();
            this.linha3 = new System.Windows.Forms.Panel();
            this.requisitoSenha = new System.Windows.Forms.Label();
            this.txtMinCaracteres = new System.Windows.Forms.Label();
            this.txtLetraMaiuscula = new System.Windows.Forms.Label();
            this.txtLetraMinuscula = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.Label();
            this.txtCaracterEspecial = new System.Windows.Forms.Label();
            this.linkPossuiConta = new System.Windows.Forms.LinkLabel();
            this.txtStatusSenha = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtVerificarCredencial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeOlhoAberto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeOlhoFechado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(56)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 392);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // Linha1
            // 
            this.Linha1.BackColor = System.Drawing.Color.DimGray;
            this.Linha1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha1.Location = new System.Drawing.Point(280, 106);
            this.Linha1.Name = "Linha1";
            this.Linha1.Size = new System.Drawing.Size(478, 1);
            this.Linha1.TabIndex = 2;
            // 
            // inputUsuario
            // 
            this.inputUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.inputUsuario.Location = new System.Drawing.Point(280, 83);
            this.inputUsuario.MaxLength = 50;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(478, 19);
            this.inputUsuario.TabIndex = 1;
            this.inputUsuario.Text = "DIGITE SEU EMAIL";
            this.inputUsuario.Enter += new System.EventHandler(this.inputUsuario_Enter);
            this.inputUsuario.Leave += new System.EventHandler(this.inputUsuario_Leave);
            // 
            // inputSenha
            // 
            this.inputSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSenha.ForeColor = System.Drawing.Color.DimGray;
            this.inputSenha.Location = new System.Drawing.Point(280, 144);
            this.inputSenha.MaxLength = 26;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(299, 19);
            this.inputSenha.TabIndex = 2;
            this.inputSenha.Text = "DIGITE SUA SENHA";
            this.inputSenha.TextChanged += new System.EventHandler(this.inputSenha_TextChanged);
            this.inputSenha.Enter += new System.EventHandler(this.inputSenha_Enter);
            this.inputSenha.Leave += new System.EventHandler(this.inputSenha_Leave);
            // 
            // Linha2
            // 
            this.Linha2.BackColor = System.Drawing.Color.DimGray;
            this.Linha2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha2.Location = new System.Drawing.Point(280, 167);
            this.Linha2.Name = "Linha2";
            this.Linha2.Size = new System.Drawing.Size(345, 1);
            this.Linha2.TabIndex = 3;
            // 
            // tituloTelaLogin
            // 
            this.tituloTelaLogin.AutoSize = true;
            this.tituloTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tituloTelaLogin.Font = new System.Drawing.Font("Arial", 20F);
            this.tituloTelaLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tituloTelaLogin.Location = new System.Drawing.Point(352, 9);
            this.tituloTelaLogin.Name = "tituloTelaLogin";
            this.tituloTelaLogin.Size = new System.Drawing.Size(342, 32);
            this.tituloTelaLogin.TabIndex = 5;
            this.tituloTelaLogin.Text = "CADASTRO DE USUÁRIO";
            this.tituloTelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(280, 298);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(478, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "CADASTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.InitialImage")));
            this.btnCancelar.Location = new System.Drawing.Point(751, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(25, 25);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iconeOlhoAberto
            // 
            this.iconeOlhoAberto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconeOlhoAberto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeOlhoAberto.Image = ((System.Drawing.Image)(resources.GetObject("iconeOlhoAberto.Image")));
            this.iconeOlhoAberto.InitialImage = null;
            this.iconeOlhoAberto.Location = new System.Drawing.Point(599, 140);
            this.iconeOlhoAberto.Name = "iconeOlhoAberto";
            this.iconeOlhoAberto.Size = new System.Drawing.Size(24, 24);
            this.iconeOlhoAberto.TabIndex = 9;
            this.iconeOlhoAberto.TabStop = false;
            this.iconeOlhoAberto.Visible = false;
            this.iconeOlhoAberto.Click += new System.EventHandler(this.iconeOlhoAberto_Click);
            // 
            // iconeOlhoFechado
            // 
            this.iconeOlhoFechado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconeOlhoFechado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeOlhoFechado.Image = ((System.Drawing.Image)(resources.GetObject("iconeOlhoFechado.Image")));
            this.iconeOlhoFechado.InitialImage = null;
            this.iconeOlhoFechado.Location = new System.Drawing.Point(599, 140);
            this.iconeOlhoFechado.Name = "iconeOlhoFechado";
            this.iconeOlhoFechado.Size = new System.Drawing.Size(24, 24);
            this.iconeOlhoFechado.TabIndex = 10;
            this.iconeOlhoFechado.TabStop = false;
            this.iconeOlhoFechado.Click += new System.EventHandler(this.iconeOlhoFechado_Click);
            // 
            // inputRepitaSenha
            // 
            this.inputRepitaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputRepitaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRepitaSenha.ForeColor = System.Drawing.Color.DimGray;
            this.inputRepitaSenha.Location = new System.Drawing.Point(280, 200);
            this.inputRepitaSenha.MaxLength = 26;
            this.inputRepitaSenha.Name = "inputRepitaSenha";
            this.inputRepitaSenha.Size = new System.Drawing.Size(345, 19);
            this.inputRepitaSenha.TabIndex = 3;
            this.inputRepitaSenha.Text = "DIGITE NOVAMENTE SUA SENHA";
            this.inputRepitaSenha.Enter += new System.EventHandler(this.inputRepitaSenha_Enter);
            this.inputRepitaSenha.Leave += new System.EventHandler(this.inputRepitaSenha_Leave);
            // 
            // linha3
            // 
            this.linha3.BackColor = System.Drawing.Color.DimGray;
            this.linha3.Cursor = System.Windows.Forms.Cursors.Default;
            this.linha3.Location = new System.Drawing.Point(280, 223);
            this.linha3.Name = "linha3";
            this.linha3.Size = new System.Drawing.Size(345, 1);
            this.linha3.TabIndex = 12;
            // 
            // requisitoSenha
            // 
            this.requisitoSenha.AutoSize = true;
            this.requisitoSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.requisitoSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.requisitoSenha.ForeColor = System.Drawing.Color.DimGray;
            this.requisitoSenha.Location = new System.Drawing.Point(633, 145);
            this.requisitoSenha.Name = "requisitoSenha";
            this.requisitoSenha.Size = new System.Drawing.Size(135, 18);
            this.requisitoSenha.TabIndex = 0;
            this.requisitoSenha.Text = "Requisitos Senha:";
            this.requisitoSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMinCaracteres
            // 
            this.txtMinCaracteres.AutoSize = true;
            this.txtMinCaracteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtMinCaracteres.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMinCaracteres.ForeColor = System.Drawing.Color.Red;
            this.txtMinCaracteres.Location = new System.Drawing.Point(633, 170);
            this.txtMinCaracteres.Name = "txtMinCaracteres";
            this.txtMinCaracteres.Size = new System.Drawing.Size(135, 16);
            this.txtMinCaracteres.TabIndex = 14;
            this.txtMinCaracteres.Text = "Mínimo 8 caracteres";
            this.txtMinCaracteres.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLetraMaiuscula
            // 
            this.txtLetraMaiuscula.AutoSize = true;
            this.txtLetraMaiuscula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLetraMaiuscula.Font = new System.Drawing.Font("Arial", 10F);
            this.txtLetraMaiuscula.ForeColor = System.Drawing.Color.Red;
            this.txtLetraMaiuscula.Location = new System.Drawing.Point(633, 190);
            this.txtLetraMaiuscula.Name = "txtLetraMaiuscula";
            this.txtLetraMaiuscula.Size = new System.Drawing.Size(107, 16);
            this.txtLetraMaiuscula.TabIndex = 15;
            this.txtLetraMaiuscula.Text = "Letra maiúscula";
            this.txtLetraMaiuscula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLetraMinuscula
            // 
            this.txtLetraMinuscula.AutoSize = true;
            this.txtLetraMinuscula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLetraMinuscula.Font = new System.Drawing.Font("Arial", 10F);
            this.txtLetraMinuscula.ForeColor = System.Drawing.Color.Red;
            this.txtLetraMinuscula.Location = new System.Drawing.Point(633, 210);
            this.txtLetraMinuscula.Name = "txtLetraMinuscula";
            this.txtLetraMinuscula.Size = new System.Drawing.Size(107, 16);
            this.txtLetraMinuscula.TabIndex = 16;
            this.txtLetraMinuscula.Text = "Letra minúscula";
            this.txtLetraMinuscula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumeros
            // 
            this.txtNumeros.AutoSize = true;
            this.txtNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNumeros.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumeros.ForeColor = System.Drawing.Color.Red;
            this.txtNumeros.Location = new System.Drawing.Point(633, 230);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(63, 16);
            this.txtNumeros.TabIndex = 17;
            this.txtNumeros.Text = "Números";
            this.txtNumeros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCaracterEspecial
            // 
            this.txtCaracterEspecial.AutoSize = true;
            this.txtCaracterEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCaracterEspecial.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCaracterEspecial.ForeColor = System.Drawing.Color.Red;
            this.txtCaracterEspecial.Location = new System.Drawing.Point(633, 250);
            this.txtCaracterEspecial.Name = "txtCaracterEspecial";
            this.txtCaracterEspecial.Size = new System.Drawing.Size(118, 16);
            this.txtCaracterEspecial.TabIndex = 18;
            this.txtCaracterEspecial.Text = "Caracter especial";
            this.txtCaracterEspecial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkPossuiConta
            // 
            this.linkPossuiConta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.linkPossuiConta.AutoSize = true;
            this.linkPossuiConta.LinkColor = System.Drawing.Color.DimGray;
            this.linkPossuiConta.Location = new System.Drawing.Point(517, 359);
            this.linkPossuiConta.Name = "linkPossuiConta";
            this.linkPossuiConta.Size = new System.Drawing.Size(241, 18);
            this.linkPossuiConta.TabIndex = 5;
            this.linkPossuiConta.TabStop = true;
            this.linkPossuiConta.Text = "Já possui conta? Faça login aqui.";
            this.linkPossuiConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPossuiConta_LinkClicked);
            // 
            // txtStatusSenha
            // 
            this.txtStatusSenha.AutoSize = true;
            this.txtStatusSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtStatusSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtStatusSenha.ForeColor = System.Drawing.Color.Red;
            this.txtStatusSenha.Location = new System.Drawing.Point(517, 241);
            this.txtStatusSenha.Name = "txtStatusSenha";
            this.txtStatusSenha.Size = new System.Drawing.Size(105, 18);
            this.txtStatusSenha.TabIndex = 19;
            this.txtStatusSenha.Text = "Senha fraca :(";
            this.txtStatusSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(280, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // txtVerificarCredencial
            // 
            this.txtVerificarCredencial.AutoSize = true;
            this.txtVerificarCredencial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtVerificarCredencial.Location = new System.Drawing.Point(277, 359);
            this.txtVerificarCredencial.Name = "txtVerificarCredencial";
            this.txtVerificarCredencial.Size = new System.Drawing.Size(184, 18);
            this.txtVerificarCredencial.TabIndex = 21;
            this.txtVerificarCredencial.Text = "Verificando credenciais...";
            this.txtVerificarCredencial.Visible = false;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 392);
            this.Controls.Add(this.txtVerificarCredencial);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtStatusSenha);
            this.Controls.Add(this.linkPossuiConta);
            this.Controls.Add(this.txtCaracterEspecial);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtLetraMinuscula);
            this.Controls.Add(this.txtLetraMaiuscula);
            this.Controls.Add(this.txtMinCaracteres);
            this.Controls.Add(this.requisitoSenha);
            this.Controls.Add(this.inputRepitaSenha);
            this.Controls.Add(this.linha3);
            this.Controls.Add(this.iconeOlhoFechado);
            this.Controls.Add(this.iconeOlhoAberto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tituloTelaLogin);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.Linha2);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.Linha1);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSignUp";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TELA DE LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeOlhoAberto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeOlhoFechado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel Linha1;
        private System.Windows.Forms.TextBox inputUsuario;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Panel Linha2;
        private System.Windows.Forms.Label tituloTelaLogin;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox iconeOlhoAberto;
        private System.Windows.Forms.PictureBox iconeOlhoFechado;
        private System.Windows.Forms.TextBox inputRepitaSenha;
        private System.Windows.Forms.Panel linha3;
        private System.Windows.Forms.Label requisitoSenha;
        private System.Windows.Forms.Label txtMinCaracteres;
        private System.Windows.Forms.Label txtLetraMaiuscula;
        private System.Windows.Forms.Label txtLetraMinuscula;
        private System.Windows.Forms.Label txtNumeros;
        private System.Windows.Forms.Label txtCaracterEspecial;
        private System.Windows.Forms.LinkLabel linkPossuiConta;
        private System.Windows.Forms.Label txtStatusSenha;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtVerificarCredencial;
    }
}

