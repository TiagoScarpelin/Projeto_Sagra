using Projeto_Sagra.Modelo;
using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();
            controle.acessar(txt_senha.Text, txt_email.Text);


            if (controle.getMensagem() == "")       // Pega a mensagem de erro que retorna da função controle e compara seu valor.
            {


                if (controle.getTem() == true)      // Pega a variavel 'tem' e compara seu valor.
                {
                    // Realiza a abertura do Form2 que seria o menu.

                    this.Hide();
                    Menu Form2 = new Menu();
                    Form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma caixa de mensagem informando que ocorreu um erro ao entrar,pois o usuário não foi encontrado.

                    MessageBox.Show("Erro ao entrar", "usuario nao encontado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                // Exibe uma caixa de mensagem informando que ocorreu um erro,a mensagem exibida provém do erro que será informado.

                MessageBox.Show(controle.getMensagem());
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
