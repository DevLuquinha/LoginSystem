namespace LoginSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Linha1 = new System.Windows.Forms.Panel();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.Linha2 = new System.Windows.Forms.Panel();
            this.tituloTelaLogin = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.iconeOlhoAberto = new System.Windows.Forms.PictureBox();
            this.iconeOlhoFechado = new System.Windows.Forms.PictureBox();
            this.linkNaoPossuiConta = new System.Windows.Forms.LinkLabel();
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
            this.panelLogo.Size = new System.Drawing.Size(250, 328);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // Linha1
            // 
            this.Linha1.BackColor = System.Drawing.Color.DimGray;
            this.Linha1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha1.Location = new System.Drawing.Point(283, 106);
            this.Linha1.Name = "Linha1";
            this.Linha1.Size = new System.Drawing.Size(475, 1);
            this.Linha1.TabIndex = 2;
            // 
            // inputUsuario
            // 
            this.inputUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.inputUsuario.Location = new System.Drawing.Point(283, 83);
            this.inputUsuario.MaxLength = 50;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(475, 19);
            this.inputUsuario.TabIndex = 1;
            this.inputUsuario.Text = "E-MAIL";
            this.inputUsuario.Enter += new System.EventHandler(this.inputUsuario_Enter);
            this.inputUsuario.Leave += new System.EventHandler(this.inputUsuario_Leave);
            // 
            // inputSenha
            // 
            this.inputSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSenha.ForeColor = System.Drawing.Color.DimGray;
            this.inputSenha.Location = new System.Drawing.Point(283, 148);
            this.inputSenha.MaxLength = 30;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(440, 19);
            this.inputSenha.TabIndex = 2;
            this.inputSenha.Text = "SENHA";
            this.inputSenha.Enter += new System.EventHandler(this.inputSenha_Enter);
            this.inputSenha.Leave += new System.EventHandler(this.inputSenha_Leave);
            // 
            // Linha2
            // 
            this.Linha2.BackColor = System.Drawing.Color.DimGray;
            this.Linha2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha2.Location = new System.Drawing.Point(283, 171);
            this.Linha2.Name = "Linha2";
            this.Linha2.Size = new System.Drawing.Size(440, 1);
            this.Linha2.TabIndex = 3;
            // 
            // tituloTelaLogin
            // 
            this.tituloTelaLogin.AutoSize = true;
            this.tituloTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tituloTelaLogin.Font = new System.Drawing.Font("Arial", 20F);
            this.tituloTelaLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tituloTelaLogin.Location = new System.Drawing.Point(409, 9);
            this.tituloTelaLogin.Name = "tituloTelaLogin";
            this.tituloTelaLogin.Size = new System.Drawing.Size(218, 32);
            this.tituloTelaLogin.TabIndex = 5;
            this.tituloTelaLogin.Text = "TELA DE LOGIN";
            this.tituloTelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.Location = new System.Drawing.Point(283, 233);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(475, 40);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtEsqueceuSenha
            // 
            this.txtEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEsqueceuSenha.AutoSize = true;
            this.txtEsqueceuSenha.LinkColor = System.Drawing.Color.DimGray;
            this.txtEsqueceuSenha.Location = new System.Drawing.Point(577, 184);
            this.txtEsqueceuSenha.Name = "txtEsqueceuSenha";
            this.txtEsqueceuSenha.Size = new System.Drawing.Size(146, 18);
            this.txtEsqueceuSenha.TabIndex = 0;
            this.txtEsqueceuSenha.TabStop = true;
            this.txtEsqueceuSenha.Text = "Esqueceu a senha?";
            this.txtEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtEsqueceuSenha_LinkClicked);
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
            this.iconeOlhoAberto.Location = new System.Drawing.Point(734, 148);
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
            this.iconeOlhoFechado.Location = new System.Drawing.Point(734, 148);
            this.iconeOlhoFechado.Name = "iconeOlhoFechado";
            this.iconeOlhoFechado.Size = new System.Drawing.Size(24, 24);
            this.iconeOlhoFechado.TabIndex = 10;
            this.iconeOlhoFechado.TabStop = false;
            this.iconeOlhoFechado.Click += new System.EventHandler(this.iconeOlhoFechado_Click);
            // 
            // linkNaoPossuiConta
            // 
            this.linkNaoPossuiConta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.linkNaoPossuiConta.AutoSize = true;
            this.linkNaoPossuiConta.LinkColor = System.Drawing.Color.DimGray;
            this.linkNaoPossuiConta.Location = new System.Drawing.Point(515, 292);
            this.linkNaoPossuiConta.Name = "linkNaoPossuiConta";
            this.linkNaoPossuiConta.Size = new System.Drawing.Size(244, 18);
            this.linkNaoPossuiConta.TabIndex = 11;
            this.linkNaoPossuiConta.TabStop = true;
            this.linkNaoPossuiConta.Text = "Não possui conta? Crie uma aqui.";
            this.linkNaoPossuiConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNaoPossuiConta_LinkClicked);
            // 
            // txtVerificarCredencial
            // 
            this.txtVerificarCredencial.AutoSize = true;
            this.txtVerificarCredencial.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtVerificarCredencial.Location = new System.Drawing.Point(280, 292);
            this.txtVerificarCredencial.Name = "txtVerificarCredencial";
            this.txtVerificarCredencial.Size = new System.Drawing.Size(184, 18);
            this.txtVerificarCredencial.TabIndex = 22;
            this.txtVerificarCredencial.Text = "Verificando credenciais...";
            this.txtVerificarCredencial.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 328);
            this.Controls.Add(this.txtVerificarCredencial);
            this.Controls.Add(this.linkNaoPossuiConta);
            this.Controls.Add(this.iconeOlhoFechado);
            this.Controls.Add(this.iconeOlhoAberto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEsqueceuSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tituloTelaLogin);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.Linha2);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.Linha1);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel txtEsqueceuSenha;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox iconeOlhoAberto;
        private System.Windows.Forms.PictureBox iconeOlhoFechado;
        private System.Windows.Forms.LinkLabel linkNaoPossuiConta;
        private System.Windows.Forms.Label txtVerificarCredencial;
    }
}

