using Projeto_Sagra.Modelo;
using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class cadastroclientes : Form
    {
        public cadastroclientes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método incluir do objeto controle, passando os valores dos campos txtNomeCliente, txtEmailCliente, txtCpfCliente e txtTelefoneCliente como argumentos.
            controle.incluir(txtNomeCliente.Text, txtEmailCliente.Text, txtCpfCliente.Text, txtTelefoneCliente.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o cliente foi cadastrado com sucesso.
                    MessageBox.Show("Cliente cadastrado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível realizar o cadastro do cliente.
                    MessageBox.Show("Não foi possível realizar o cadastro", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método atualizar do objeto controle, passando os valores dos campos txtNomeCliente, txtEmailCliente, txtCpfCliente e txtTelefoneCliente como argumentos.
            controle.atualizar(txtNomeCliente.Text, txtEmailCliente.Text, txtCpfCliente.Text, txtTelefoneCliente.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o cliente foi atualizado com sucesso.
                    MessageBox.Show("Cliente atualizado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível atualizar o cliente.
                    MessageBox.Show("Não foi possível atualizar", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método deletar do objeto controle, passando o valor do campo txtCpfCliente como argumento.
            controle.deletar(txtCpfCliente.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o cliente foi deletado com sucesso.
                    MessageBox.Show("Cliente deletado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível deletar o cliente.
                    MessageBox.Show("Não foi possível deletar", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formulario = new Menu();
            formulario.ShowDialog();
            this.Close();
        }
    }

}
