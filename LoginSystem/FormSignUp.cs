using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using Newtonsoft.Json;


namespace LoginSystem
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        #region COMANDOS / REFERENCIAS PARA MOVIMENTAR O FORMULARIO 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        #region BOTÕES 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da tela de registro de usuário?", "Sair do Registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            // http da minha API
            var httpClient = new HttpClient();
            var url = "https://localhost:7010/api/auth/signup";

            var dados = new
            {
                Email = inputUsuario.Text,
                Password = inputSenha.Text
            };

            string json = JsonConvert.SerializeObject(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cadastro de usuário realizado com sucesso! Bem-vindo ao Plugin Makeng", "Cadastro Concluido" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string erro = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Erro: " + erro, "Erro ao cadastrar usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void linkPossuiConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion

        #region DICA DIGITAÇÃO DOS INPUTS USUARIO E SENHA
        private void inputUsuario_Enter(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "DIGITE SEU EMAIL")
            {
                inputUsuario.Text = "";
                inputUsuario.ForeColor = Color.LightGray;
            }
        }
        private void inputUsuario_Leave(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "")
            {
                inputUsuario.Text = "DIGITE SEU EMAIL";
                inputUsuario.ForeColor = Color.DimGray;
            }
        }

        private void inputSenha_Enter(object sender, EventArgs e)
        {
            if (inputSenha.Text == "DIGITE SUA SENHA")
            {
                inputSenha.Text = "";
                inputSenha.ForeColor = Color.LightGray;
                // Caso o olho de ocultar a senha esteja ativado, o input será de password
                inputSenha.UseSystemPasswordChar = iconeOlhoFechado.Visible == true;
            }
        }
        private void inputSenha_Leave(object sender, EventArgs e)
        {
            if (inputSenha.Text == "")
            {
                inputSenha.Text = "DIGITE SUA SENHA";
                inputSenha.ForeColor = Color.DimGray;
                // Sempre que estiver vazio, mostrar o valor da senha, entao o password tem que ser falso
                inputSenha.UseSystemPasswordChar = false;
            }
        }
        private void inputRepitaSenha_Enter(object sender, EventArgs e)
        {
            if (inputRepitaSenha.Text == "DIGITE NOVAMENTE SUA SENHA")
            {
                inputRepitaSenha.Text = "";
                inputRepitaSenha.ForeColor = Color.LightGray;
                // Caso o olho de ocultar a senha esteja ativado, o input será de password
                inputRepitaSenha.UseSystemPasswordChar = iconeOlhoFechado.Visible == true;
            }
        }

        private void inputRepitaSenha_Leave(object sender, EventArgs e)
        {
            if (inputRepitaSenha.Text == "")
            {
                inputRepitaSenha.Text = "DIGITE NOVAMENTE SUA SENHA";
                inputRepitaSenha.ForeColor = Color.DimGray;
                // Sempre que estiver vazio, mostrar o valor da senha, entao o password tem que ser falso
                inputRepitaSenha.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region MOSTRAR SENHA, OLHO FECHADO E OLHO ABERTO
        private void iconeOlhoFechado_Click(object sender, EventArgs e)
        {
            inputSenha.UseSystemPasswordChar = false;
            inputRepitaSenha.UseSystemPasswordChar = false;

            iconeOlhoFechado.Visible = iconeOlhoAberto.Visible == true;
            // Caso o olho fechado nao esteja visivel, mostrar o olho aberto
            iconeOlhoAberto.Visible  = iconeOlhoFechado.Visible == false;
        }
        private void iconeOlhoAberto_Click(object sender, EventArgs e)
        {
            // Para não ocultar a dica, pois quando é senha, não deve esconder a dica
            if (inputSenha.Text == "DIGITE SUA SENHA")
            {
                inputSenha.UseSystemPasswordChar = false;
            }
            if (inputRepitaSenha.Text == "DIGITE NOVAMENTE SUA SENHA")
            {
                inputRepitaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                inputSenha.UseSystemPasswordChar = true;
                inputRepitaSenha.UseSystemPasswordChar = true;
            }
                
            iconeOlhoAberto.Visible  = iconeOlhoFechado.Visible == true;
            // Caso o olho aberto nao esteja visivel, mostrar o olho falso
            iconeOlhoFechado.Visible = iconeOlhoAberto.Visible == false;
        }
        #endregion

        #region MOVIMENTAÇÃO DO FORMULÁRIO
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

       
    }
}
