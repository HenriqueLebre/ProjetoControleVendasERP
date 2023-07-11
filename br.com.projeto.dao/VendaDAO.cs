using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    public class VendaDAO
    {

        private MySqlConnection conn;

        public VendaDAO()
        {
            this.conn = new ConnectionFactory().Getconnection();
        }

        #region CadastraVenda

        public void CadastraVenda(Venda obj)
        {
            try
            {

                string cCmdSql = @"INSERT INTO
                    tb_vendas
                        (cliente_id, data_venda, total_venda, observacoes)
                    VALUES
                        (@cliente_id, @data_venda, @total_venda, @obs);";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql,conn);
                execcmd.Parameters.AddWithValue(@"cliente_id", obj.cliente_id);
                execcmd.Parameters.AddWithValue(@"data_venda", obj.data_venda);
                execcmd.Parameters.AddWithValue(@"total_venda", obj.total);
                execcmd.Parameters.AddWithValue(@"obs", obj.observacao);

                conn.Open();
                execcmd.ExecuteNonQuery();

                MessageBox.Show("Venda realizada com sucesso!");
                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um falha, vale as informações: " + erro);
            }
        }

        #endregion

        #region RetornaIdUltVenda

        public int RetornaIdUltVenda()
        {
            try
            {
                int idvenda = 0;
                string cCmdSql = "SELECT max(id) id from vendas;";
                MySqlCommand execcmd = new MySqlCommand(@cCmdSql,conn);

                conn.Open();

                MySqlDataReader rs = execcmd.ExecuteReader();

                if (rs.Read()) 
                {
                    idvenda = rs.GetInt32("id");
                    

                }

                conn.Close();
                return idvenda;



            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível identificar a última venda, analise as informações: " + erro);
                return 0;
            }
        }

        #endregion



        #region listaVendasPorPeriodo

        public DataTable listaVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {

                DataTable tabelaHistorico = new DataTable();

                string cCmdSql = @"SELECT 
                                       v.id                 as 'Código',
                                       v.data_venda         as 'Data da Venda',
                                       c.nome               as 'Cliente',
                                       v.total_venda        as 'Total',
                                       v.observacoes        as 'Obs'
                                  FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)
                                  WHERE v.data_venda BETWEEN @dataincio and @datafim";

                MySqlCommand execcmd = new MySqlCommand(@cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@datainicio", datainicio);
                execcmd.Parameters.AddWithValue("@datafim"   , datafim);

                conn.Open();
                execcmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao lista Vendas, valide as informações: " + erro);
                return null;
            }
        }

        #endregion
    }
}
