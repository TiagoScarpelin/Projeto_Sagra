using MySqlConnector;

namespace Projeto_Sagra.Conexao_db
{
    public class Conexao
    {
        MySqlConnection conn = new MySqlConnection();

        public Conexao()
        {
            conn.ConnectionString = @"server=localhost;Port=3306;Database=sagra;User Id=root;Password=ti19010203";
        }

        public MySqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;

        }

        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

        }

    }

}
