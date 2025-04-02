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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panelLogo.Size = new System.Drawing.Size(250, 358);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // Linha1
            // 
            this.Linha1.BackColor = System.Drawing.Color.DimGray;
            this.Linha1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha1.Location = new System.Drawing.Point(290, 106);
            this.Linha1.Name = "Linha1";
            this.Linha1.Size = new System.Drawing.Size(478, 1);
            this.Linha1.TabIndex = 2;
            // 
            // inputUsuario
            // 
            this.inputUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inputUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.inputUsuario.Location = new System.Drawing.Point(290, 83);
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
            this.inputSenha.Location = new System.Drawing.Point(290, 144);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(345, 19);
            this.inputSenha.TabIndex = 2;
            this.inputSenha.Text = "DIGITE SUA SENHA";
            this.inputSenha.Enter += new System.EventHandler(this.inputSenha_Enter);
            this.inputSenha.Leave += new System.EventHandler(this.inputSenha_Leave);
            // 
            // Linha2
            // 
            this.Linha2.BackColor = System.Drawing.Color.DimGray;
            this.Linha2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Linha2.Location = new System.Drawing.Point(290, 167);
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
            this.btnRegistrar.Location = new System.Drawing.Point(290, 293);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(478, 40);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            this.iconeOlhoAberto.Location = new System.Drawing.Point(290, 239);
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
            this.iconeOlhoFechado.Location = new System.Drawing.Point(290, 239);
            this.iconeOlhoFechado.Name = "iconeOlhoFechado";
            this.iconeOlhoFechado.Size = new System.Drawing.Size(24, 24);
            this.iconeOlhoFechado.TabIndex = 10;
            this.iconeOlhoFechado.TabStop = false;
            this.iconeOlhoFechado.Click += new System.EventHandler(this.iconeOlhoFechado_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(290, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 19);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "DIGITE NOVAMENTE SUA SENHA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(290, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 1);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(641, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Requisitos Senha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(641, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mínimo 8 caracteres";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(641, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Letra maiúscula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(641, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Letra minúscula";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(641, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Números";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(641, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Caracter especial";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
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
            this.Opacity = 0.95D;
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
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox iconeOlhoAberto;
        private System.Windows.Forms.PictureBox iconeOlhoFechado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

