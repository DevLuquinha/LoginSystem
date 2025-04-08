using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Net.Http;

namespace LoginSystem
{
    public partial class FormLogin : Form
    {
        FormSignUp formSignUp = new FormSignUp();
        public FormLogin()
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
            if (MessageBox.Show("Deseja sair da tela de login?", "Sair do Login?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            // http da minha API
            var httpClient = new HttpClient();
            var url = "https://localhost:7010/api/auth/login";

            // Objeto com os dados necessários
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
                MessageBox.Show("Login efetuado com sucesso! Bem-vindo novamente ao Plugin Makeng!", "Login Finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string erro = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Erro: " + erro, "Erro no login!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void linkNaoPossuiConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignUp.Show();
            Hide();
        }
        #endregion

        #region DICA DIGITAÇÃO DOS INPUTS USUARIO E SENHA
        private void inputUsuario_Enter(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "USUARIO")
            {
                inputUsuario.Text = "";
                inputUsuario.ForeColor = Color.LightGray;
            }
        }
        private void inputUsuario_Leave(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "")
            {
                inputUsuario.Text = "USUARIO";
                inputUsuario.ForeColor = Color.DimGray;
            }
        }
        private void inputSenha_Enter(object sender, EventArgs e)
        {
            if (inputSenha.Text == "SENHA")
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
                inputSenha.Text = "SENHA";
                inputSenha.ForeColor = Color.DimGray;
                // Sempre que estiver vazio, mostrar o valor da senha, entao o password tem que ser falso
                inputSenha.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region MOSTRAR SENHA, OLHO FECHADO E OLHO ABERTO
        private void iconeOlhoFechado_Click(object sender, EventArgs e)
        {
            inputSenha.UseSystemPasswordChar = false;
            iconeOlhoFechado.Visible = iconeOlhoAberto.Visible == true;
            // Caso o olho fechado nao esteja visivel, mostrar o olho aberto
            iconeOlhoAberto.Visible  = iconeOlhoFechado.Visible == false;
        }
        private void iconeOlhoAberto_Click(object sender, EventArgs e)
        {
            // Para não ocultar a dica, pois quando é senha, não deve esconder a dica
            if (inputSenha.Text == "SENHA")
                inputSenha.UseSystemPasswordChar = false;
            else
                inputSenha.UseSystemPasswordChar = true;
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
