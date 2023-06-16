using Projeto_Sagra.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;


namespace Projeto_Sagra
{
    public partial class compra : Form
    {
        public compra()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int numero = int.Parse(txtNumero.Text);

            gridviewCompra.DataSource = controle.consultaProdutoCompra(numero);

        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            Controle valor = new Controle();

            int numero = int.Parse(txtNumero.Text);

            float teste = valor.consultarPRO(numero);

            int quantidade = Decimal.ToInt32(numericQtde.Value);

            float valor_total = teste * quantidade;

           
            controle.incluirCompra(numero, quantidade,valor_total, txtFunc.Text , txtCpfCliente.Text);

            if (controle.getMensagem() == "")
            {
                if (controle.getTem() == true)
                {
                    // Exibe uma mensagem informando que o produto foi cadastrado com sucesso.
                    MessageBox.Show("Produto cadastrado", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridviewCompra.DataSource = controle.consultarCompra();
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

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void lblCpfCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
