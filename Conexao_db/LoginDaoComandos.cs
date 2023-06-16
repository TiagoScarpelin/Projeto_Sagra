using Projeto_Sagra.Modelo;
using System;
using MySqlConnector;
using System.Data;

namespace Projeto_Sagra.Conexao_db
{
    public class LoginDaoComando
    {
        private bool tem = false;
        private MySqlConnection conn;
        private String mensagem = "";
        MySqlCommand comm = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
        Controle abc = new Controle();


        public String getMensagem()
        {
            return (this.mensagem);
        }

        public bool verificarLogin(String login, String senha)
        {
            comm.CommandText = "SELECT * FROM login Where login = @login AND senha = @senha";
            comm.Parameters.AddWithValue("@login", login);
            comm.Parameters.AddWithValue("@senha", senha);


            try
            {
                comm.Connection = con.conectar();
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    this.tem = true;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return this.tem;

        }

        public bool inserirCliente(String nome, String email, String cpf, String telefone)
        {
            comm.CommandText = "INSERT INTO cliente VALUES ('" + @cpf + "','" + @nome + "','" + @email + "','" + @telefone + "');";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                con.desconectar();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return this.tem;

        }

        public bool atualizarCliente(String nome, String email, String cpf, String telefone)
        {

            comm.CommandText = "UPDATE cliente SET nome = '" + @nome + "', email = '" + @email + "', telefone = '" + @telefone + "' WHERE cpf = '" + @cpf + "' ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }

        public bool deletarCliente(String cpf)
        {

            comm.CommandText = "DELETE FROM cliente WHERE cpf = '" + @cpf + "' ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }



        //Cadastrar Fornecedor




        public bool inserirFornecedor(String nome, String email, String cnpf, String telefone)

        {
            comm.CommandText = "INSERT INTO fornecedor VALUES ('" + @cnpf + "','" + @nome + "','" + @email + "','" + @telefone + "');";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                con.desconectar();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return this.tem;

        }


        public bool atualizarFornecedor(String nome, String email, String cnpj, String telefone)
        {

            comm.CommandText = "UPDATE fornecedor SET nome = '" + @nome + "', email = '" + @email + "', telefone = '" + @telefone + "' WHERE cnpj = '" + @cnpj + "' ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }

        public bool deletarFornecedor(String cnpj)
        {

            comm.CommandText = "DELETE FROM fornecedor WHERE cnpj = '" + @cnpj + "' ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }




        // Cadastro Produtos



        public bool inserirProduto(int numero,String nome, String quantidade,float valor)

        {
            comm.CommandText = "INSERT INTO produtos (numero,nome,quantidade,valor) VALUES ('" + @numero + "','" + @nome + "', '" + @quantidade + "','" + @valor + "');";

            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                con.desconectar();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return this.tem;

        }



        public bool atualizarProduto(int numero, String nome, String quantidade,float valor)
        {

            comm.CommandText = "UPDATE produtos SET nome = '" + @nome + "', quantidade = '" + @quantidade + "', '" + @valor + "' WHERE numero = " + @numero + ";";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }


        public bool deletarProduto(int numero)
        {

            comm.CommandText = "DELETE FROM produtos WHERE numero = " + @numero + " ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }


            return this.tem;

        }

        // RECIBOS



        public DataTable ConsultarRecibo(int numero)
        {

            comm.CommandText = "SELECT numero AS 'Codigo do produto',data_compra AS 'Data da compra',valor_total AS 'Valor Total',id_funcionario AS 'Funcionario',cpf_cliente AS 'CPF do Cliente' FROM recibo WHERE id = " + @numero + " ;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return null;

        }


        //PRODUTOS


        public DataTable ConsultarProdutos()
        {

            comm.CommandText = "SELECT * FROM produtos;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return null;

        }


        //COMPRA


        public bool registrarCompra(int numero, int quantidade,float valor_total, String func, String cliente)

        {

            // PEGA A DATA ATUAL E FORMATA ELA (YYYY-MM-DD)

            String formatarDia = String.Format("{0:s}", DateTime.Today);

            comm.CommandText = "INSERT INTO recibo (numero,quantidade,data_compra,valor_total,id_funcionario,cpf_cliente) VALUES ('" + @numero + "','" + @quantidade + "','" + @formatarDia + "','" + @valor_total + "','" + @func + "','" + @cliente + "')";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);
                comando.ExecuteNonQuery();
                con.desconectar();
                this.tem = true;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return this.tem;

        }


        public DataTable ConsultarCompra()
        {

            comm.CommandText = "SELECT * FROM compra;";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return null;

        }

        public DataTable ConsultarProCompra(int numero)
        {

            comm.CommandText = "SELECT * FROM produtos where numero = '" + @numero + "';";


            try
            {
                comm.Connection = con.conectar();

                MySqlCommand comando = new MySqlCommand(comm.CommandText, comm.Connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }

            return null;

        }





        //TESTE



        public float consultarValor(int numero)
        {
            comm.CommandText = "SELECT * FROM produtos Where numero = " + @numero + ";";

            float valor = 0;


            try
            {
                comm.Connection = con.conectar();
                dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    valor = Convert.ToInt32(dr["valor"].ToString());
                    return valor;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Deu ruim!";
            }

            return valor;

        }



    }
}
