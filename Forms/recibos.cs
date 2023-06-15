using Projeto_Sagra.Modelo;
using System;
using System.Windows.Forms;

namespace Projeto_Sagra
{
    public partial class recibos : Form
    {
        public recibos()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            int recibo = int.Parse(txtRecibo.Text);  // Transforma o texto do txtRecibo em um numero inteiro

            // Define a fonte de dados do gridview como o resultado da consulta de recibos do objeto controle.
            gridview.DataSource = controle.consultarR(recibo);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
