using Projeto_Sagra.Modelo;
using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int numero = int.Parse(txtId.Text);

            // Chama o método incluirP do objeto controle, passando os valores dos campos txtNomeP e txtQuantidadeP como argumentos.
            controle.incluirP(numero, txtNomeP.Text, txtQuantidadeP.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o produto foi cadastrado com sucesso.
                    MessageBox.Show("Produto cadastrado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridviewProdutos.DataSource = controle.consultarP();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível realizar o cadastro do produto.
                    MessageBox.Show("Não foi possível realizar o cadastro", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void btnAttProdutos_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int numero = int.Parse(txtId.Text);

            // Chama o método atualizarP do objeto controle, passando os valores do ID, txtNomeP e txtQuantidadeP como argumentos.
            controle.atualizarP(numero, txtNomeP.Text, txtQuantidadeP.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o produto foi atualizado com sucesso.
                    MessageBox.Show("Produto atualizado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridviewProdutos.DataSource = controle.consultarP();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível realizar a atualização do produto.
                    MessageBox.Show("Não foi possível realizar a atualização do produto", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Exibe uma mensagem com a mensagem de erro obtida do objeto controle.
                MessageBox.Show(controle.getMensagem());
            }
        }

        private void btnDelProdutos_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int numero = int.Parse(txtId.Text);

            // Chama o método deletarP do objeto controle, passando o valor do ID como argumento.
            controle.deletarP(numero);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o produto foi deletado com sucesso.
                    MessageBox.Show("Produto deletado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridviewProdutos.DataSource = controle.consultarP();
                }
                else
                {
                    // Exibe uma mensagem informando que não foi possível deletar o produto.
                    MessageBox.Show("Não foi possível deletar o produto", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void produtos_Load(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            gridviewProdutos.DataSource = controle.consultarP();

        }
    }

}
