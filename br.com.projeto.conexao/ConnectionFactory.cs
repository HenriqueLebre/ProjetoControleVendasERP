using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        // conexao com o banco

        public MySqlConnection Getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
                
            return new MySqlConnection(conexao);
        }
    }
}
