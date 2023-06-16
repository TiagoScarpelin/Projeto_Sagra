using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroC_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastroclientes cadastroclientes = new cadastroclientes();     // Cria uma nova instância do Cadastroclientes
            cadastroclientes.ShowDialog();                                  // Exibe o Form Cadastroclientes
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroF_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastroempresa cadastroempresa = new cadastroempresa();             // Cria uma nova instância do cadastroempresa
            cadastroempresa.ShowDialog();                                        // Exibe o Form cadastroempresa
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)             
        {
            this.Hide();
            produtos produto = new produtos();                                   // Cria uma nova instância do produtos
            produto.ShowDialog();                                                // Exibe o Form produto
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            recibos recibo = new recibos();                                   // Cria uma nova instância do recibos
            recibo.ShowDialog();                                              // Exibe o Form recibos
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();                                                     // Fecha o programa
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            this.Hide();
            compra compras = new compra();                                   // Cria uma nova instância do recibos
            compras.ShowDialog();                                              // Exibe o Form recibos
            this.Close();
        }
    }
}
