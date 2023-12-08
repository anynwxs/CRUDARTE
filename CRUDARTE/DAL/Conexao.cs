using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUDARTE.DAL
{
    internal class Conexao
    {
        string conecta = "SERVER=localhost; DATABASE=pessoas; UID=root; PWD=suport99";

        protected MySqlConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
