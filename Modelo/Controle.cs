using Projeto_Sagra.Conexao_db;
using System;
using System.Data;

namespace Projeto_Sagra.Modelo
{
    public class Controle
    {
        private bool tem;
        private String mensagem = "";

        public bool getTem()
        {
            return this.tem;
        }

        public String getMensagem()
        {
            return (this.mensagem);
        }

        public bool acessar(String login, String senha)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.verificarLogin(login, senha);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool incluir(String nome, String email, String cpf, String telefone)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.inserirCliente(nome, email, cpf, telefone);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool atualizar(String nome, String email, String cpf, String telefone)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.atualizarCliente(nome, email, cpf, telefone);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool deletar(String cpf)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.deletarCliente(cpf);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }



        // CADASTRO DE FORNECEDORES



        public bool incluirF(String nome, String email, String cnpf, String telefone)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.inserirFornecedor(nome, email, cnpf, telefone);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool atualizarF(String nome, String email, String cnpj, String telefone)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.atualizarFornecedor(nome, email, cnpj, telefone);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool deletarF(String cnpj)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.deletarFornecedor(cnpj);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }





        //CADASTRO DE PRODUTOS




        public bool incluirP(int numero,String nome, String quantidade)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.inserirProduto(numero, nome, quantidade);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }



        public bool atualizarP(int numero, String nome, String quantidade)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.atualizarProduto(numero, nome, quantidade);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }

        public bool deletarP(int numero)
        {

            LoginDaoComando loginDao = new LoginDaoComando();
            this.tem = loginDao.deletarProduto(numero);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return this.tem;
        }


        //DATAGRIDVIEW  

        //RECIBOS


        public DataTable consultarR(int numero)
        {

            LoginDaoComando loginDao = new LoginDaoComando();

            DataTable dataTable = new DataTable();

            dataTable = loginDao.ConsultarRecibo(numero);

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return dataTable;
        }



        //PRODUTOS

        public DataTable consultarP()
        {

            LoginDaoComando loginDao = new LoginDaoComando();

            DataTable dataTable = new DataTable();

            dataTable = loginDao.ConsultarProdutos();

            if (loginDao.getMensagem() != "")
            {
                this.mensagem = loginDao.getMensagem();
            }

            return dataTable;
        }

    }
}
