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
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(56)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 360);
            this.panelLogo.TabIndex = 0;
            // 
            // Linha1
            // 
            this.Linha1.BackColor = System.Drawing.Color.DimGray;
            this.Linha1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha1.Location = new System.Drawing.Point(290, 106);
            this.Linha1.Name = "Linha1";
            this.Linha1.Size = new System.Drawing.Size(440, 1);
            this.Linha1.TabIndex = 1;
            // 
            // inputUsuario
            // 
            this.inputUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.inputUsuario.Location = new System.Drawing.Point(290, 83);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(440, 19);
            this.inputUsuario.TabIndex = 2;
            this.inputUsuario.Text = "USUARIO";
            // 
            // inputSenha
            // 
            this.inputSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSenha.ForeColor = System.Drawing.Color.DimGray;
            this.inputSenha.Location = new System.Drawing.Point(290, 148);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(440, 19);
            this.inputSenha.TabIndex = 4;
            this.inputSenha.Text = "SENHA";
            // 
            // Linha2
            // 
            this.Linha2.BackColor = System.Drawing.Color.DimGray;
            this.Linha2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha2.Location = new System.Drawing.Point(290, 171);
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
            this.tituloTelaLogin.Location = new System.Drawing.Point(417, 9);
            this.tituloTelaLogin.Name = "tituloTelaLogin";
            this.tituloTelaLogin.Size = new System.Drawing.Size(218, 32);
            this.tituloTelaLogin.TabIndex = 5;
            this.tituloTelaLogin.Text = "TELA DE LOGIN";
            this.tituloTelaLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.Location = new System.Drawing.Point(290, 233);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(440, 40);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtEsqueceuSenha
            // 
            this.txtEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.txtEsqueceuSenha.AutoSize = true;
            this.txtEsqueceuSenha.LinkColor = System.Drawing.Color.DimGray;
            this.txtEsqueceuSenha.Location = new System.Drawing.Point(584, 184);
            this.txtEsqueceuSenha.Name = "txtEsqueceuSenha";
            this.txtEsqueceuSenha.Size = new System.Drawing.Size(146, 18);
            this.txtEsqueceuSenha.TabIndex = 7;
            this.txtEsqueceuSenha.TabStop = true;
            this.txtEsqueceuSenha.Text = "Esqueceu a senha?";
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
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 360);
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
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
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
    }
}

