using Projeto_Sagra.Modelo;
using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class cadastroempresa : Form
    {
        public cadastroempresa()
        {
            InitializeComponent();
        }

        private void cadastroempresa_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método deletarF do objeto controle, passando o valor do campo txtCnpfF como argumento.
            controle.deletarF(txtCnpfF.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o fornecedor foi deletado com sucesso.
                    MessageBox.Show("Fornecedor deletado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível deletar o fornecedor.
                    MessageBox.Show("Não foi possível deletar", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método incluirF do objeto controle, passando os valores dos campos txtNomeF, txtEmailF, txtCnpfF e txtTelefoneF como argumentos.
            controle.incluirF(txtNomeF.Text, txtEmailF.Text, txtCnpfF.Text, txtTelefoneF.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o fornecedor foi cadastrado com sucesso.
                    MessageBox.Show("Fornecedor cadastrado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível realizar o cadastro do fornecedor.
                    MessageBox.Show("Não foi possível realizar o cadastro", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            // Chama o método atualizarF do objeto controle, passando os valores dos campos txtNomeF, txtEmailF, txtCnpfF e txtTelefoneF como argumentos.
            controle.atualizarF(txtNomeF.Text, txtEmailF.Text, txtCnpfF.Text, txtTelefoneF.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o fornecedor foi atualizado com sucesso.
                    MessageBox.Show("Fornecedor Atualizado!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Menu formulario = new Menu();
                    formulario.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível atualizar o fornecedor.
                    MessageBox.Show("Não foi possível atualizar", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Esconde a janela atual.
            this.Hide();

            // Cria uma instância do Form2.
            Menu formulario = new Menu();

            // Exibe o Form2 como uma janela modal.
            formulario.ShowDialog();

            // Fecha a janela atual.
            this.Close();
        }
    }

}

