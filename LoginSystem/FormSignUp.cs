using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;


namespace LoginSystem
{
    public partial class FormSignUp : Form
    {
        FormLogin CurrentFormLogin;
        private string Email { get; set; }
        private string Password { get; set; }

        public FormSignUp(FormLogin currentForm)
        {
            InitializeComponent();
            CurrentFormLogin = currentForm;
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
                Close();
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            #region VALIDAÇÃO DOS INPUTS
            if (!inputUsuario.Text.Contains("@"))
            {
                MessageBox.Show("Digite um e-mail válido! Verifique o e-mail digitado!", "Erro ao cadastrar usuário!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtStatusSenha.Text == "Senha fraca :(")
            {
                MessageBox.Show("Senha muito fraca! Por favor registre uma senha mais segura!", "Erro ao cadastrar usuário!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (inputSenha.Text != inputRepitaSenha.Text)
            {
                MessageBox.Show("As senhas não conferem, digite a senha corretamente!", "Erro ao cadastrar usuário!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            #region LIMPEZA DOS INPUTS
            // Retira os espaços em branco do começo e do final
            Email = inputUsuario.Text.Trim();   

            Password = inputSenha.Text.Trim();
            #endregion

            if(MessageBox.Show($"Realmente deseja criar uma conta com o e-mail:\n{Email}?", "Criar conta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                // http da minha API
                var httpClient = new HttpClient();
                string url = "https://login-api-us0s.onrender.com/api/Auth/signup";

                // Objeto com os dados necessários
                var dados = new
                {
                    Uid = Guid.NewGuid().ToString(),
                    Email = Email,
                    Password = Password
                };

                string json = JsonConvert.SerializeObject(dados);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Informa ao usuario que está sendo enviado a requisição
                txtVerificarCredencial.Text = "Verificando credenciais...";
                txtVerificarCredencial.ForeColor = Color.DodgerBlue;
                txtVerificarCredencial.Visible = true;
                linkPossuiConta.Enabled = false;
                btnRegistrar.Enabled = false;

                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    txtVerificarCredencial.Text = "Cadastro realizado com sucesso!";
                    MessageBox.Show("Cadastro de usuário realizado com sucesso! Bem-vindo ao Software do Luquinhas!", "Cadastro Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    // Caso o cadastro não seja realizado, mostra a mensagem de erro
                    txtVerificarCredencial.Text = "Erro ao cadastrar usuário!";
                    txtVerificarCredencial.ForeColor = Color.Red;
                    btnRegistrar.Enabled = true;
                    linkPossuiConta.Enabled = true;
                    // Lê o conteúdo da resposta
                    string erro = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Erro: " + erro, "Erro ao cadastrar usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar o usuário, " +
                    "verifique sua conexão wifi e tente novamente, caso o erro persistir entrar em contato com o suporte!", 
                    "Erro cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void linkPossuiConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Limpa os inputs
            inputUsuario.Text = "DIGITE SEU EMAIL";
            inputUsuario.ForeColor = Color.DimGray;
            inputSenha.Text = "DIGITE SUA SENHA";
            inputSenha.ForeColor = Color.DimGray;
            inputSenha.UseSystemPasswordChar = false;
            inputRepitaSenha.Text = "DIGITE NOVAMENTE SUA SENHA";
            inputRepitaSenha.ForeColor = Color.DimGray;
            inputRepitaSenha.UseSystemPasswordChar = false;

            // Limpa o icone de olho
            iconeOlhoFechado.Visible = true;
            iconeOlhoAberto.Visible = false;

            // Limpa requisitos senha
            txtMinCaracteres.ForeColor = Color.Red;
            txtLetraMaiuscula.ForeColor = Color.Red;
            txtLetraMinuscula.ForeColor = Color.Red;
            txtNumeros.ForeColor = Color.Red;
            txtCaracterEspecial.ForeColor = Color.Red;

            Close();
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

        #region DIGITAÇÃO DOS INPUTS
        private void inputSenha_TextChanged(object sender, EventArgs e)
        {
            if(inputSenha.Text == "DIGITE SUA SENHA")
                inputSenha.UseSystemPasswordChar = false;
            else
            {
                // Verifica se a senha tem pelo menos 8 caracteres
                if (inputSenha.Text.Length >= 8)
                {
                    txtMinCaracteres.ForeColor = Color.Green;
                }
                else
                {
                    txtMinCaracteres.ForeColor = Color.Red;
                }

                // Verifica se a senha tem pelo menos 1 letra maiúscula
                if (inputSenha.Text.Any(char.IsUpper))
                {
                    txtLetraMaiuscula.ForeColor = Color.Green;
                }
                else
                {
                    txtLetraMaiuscula.ForeColor = Color.Red;
                }

                // Verifica se a senha tem pelo menos 1 letra minúscula
                if (inputSenha.Text.Any(char.IsLower))
                { 
                    txtLetraMinuscula.ForeColor = Color.Green;
                }
                else
                {
                    txtLetraMinuscula.ForeColor = Color.Red;
                }

                // Verifica se a senha tem pelo menos 1 número
                if (inputSenha.Text.Any(char.IsDigit))
                {
                    txtNumeros.ForeColor = Color.Green;
                }
                else
                {
                    txtNumeros.ForeColor = Color.Red;
                }

                // Verifica se a senha tem pelo menos 1 caractere especial
                if (inputSenha.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
                {
                    txtCaracterEspecial.ForeColor = Color.Green;
                }
                else
                {
                    txtCaracterEspecial.ForeColor = Color.Red;
                }

                // Verifica a força da senha
                string passwordStrength = GetPasswordStrength(inputSenha.Text);
                txtStatusSenha.Text = passwordStrength;

                switch (passwordStrength)
                {
                    case "Senha fraca :(":
                        txtStatusSenha.ForeColor = Color.Red;
                        break;
                    case "Senha média :o":
                        txtStatusSenha.ForeColor = Color.Yellow;
                        break;
                    case "Senha forte :)":
                        txtStatusSenha.ForeColor = Color.Green;
                        break;
                }
                
            }
        }

        private string GetPasswordStrength(string password)
        {
            int score = 0;
            if (password.Length >= 8) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(c => !char.IsLetterOrDigit(c))) score++;
            progressBar1.Value = score * 20;

            switch (score)
            {
                case 0:
                case 1:
                case 2:
                    return "Senha fraca :(";
                case 3:
                case 4:
                    return "Senha média :o";
                case 5:
                    return "Senha forte :)";
                default:
                    return "Senha fraca :(";
            }
        }
        #endregion
    }
}
