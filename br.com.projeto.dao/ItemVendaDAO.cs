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
    public class ItemVendaDAO
    {

        private MySqlConnection conn;

        public ItemVendaDAO()
        {
            this.conn = new ConnectionFactory().Getconnection();

        }

        #region CadastraItemVenda

        public void CadastraItemVenda(ItemVenda obj)
        {
            try
            {
                string cCmdSql = @"INSERT INTO
                    tb_itensvendas
                        (venda_id, produto_id, qtd, subtotal)
                    VALUES
                        (@venda_id, @produto_id, @qtd, @subtotal);";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue(@"venda_id",    obj.venda_id);
                execcmd.Parameters.AddWithValue(@"produto_id",  obj.produto_id);
                execcmd.Parameters.AddWithValue(@"qtd",         obj.qtd);
                execcmd.Parameters.AddWithValue(@"subtotal",    obj.subtotal);

                conn.Open();
                execcmd.ExecuteNonQuery();

                MessageBox.Show("Item cadastrado com sucesso!");
                conn.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Obtivemos um erro, valide as informações: " + erro);
                throw;
            }
        }

        #endregion

        #region listaItemPorVenda

        public DataTable listaItemPorVenda(int venda_id)
        {
            try
            {

                DataTable tabelItens = new DataTable();


                string cCmdSql = @"SELECT i.id as 'Código',
                                          p.descricao as 'Descrição',
                                          i.qtd as 'Quantidade',
                                          p.preco as 'Preço',
                                          i.subtotal as 'Subtotal'
                                    FROM tb_itensvendas as i join
                                         tb_produtos as p on (i.produto = p.id)
                                    WHERE venda_id=@venda_id";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue(@"venda_id", venda_id);


                conn.Open();
                execcmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);
                da.Fill(tabelItens);
                conn.Close();

                return tabelItens;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Obtivemos um erro, valide as informações: " + erro);
                throw;
            }
        }

        #endregion

    }
}
