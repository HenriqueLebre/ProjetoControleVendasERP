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
    public class FornecedorDAO
    {
        private MySqlConnection conn;
        public FornecedorDAO()
        {
            this.conn = new ConnectionFactory().Getconnection();
        }

        #region CadastrarFornecedor

        public void CadastrarFornecedor(Fornecedor obj)
        {
                try
                {
                    string cCmdSql = @"INSERT INTO
                    tb_fornecedores
                        (nome, cnpj, email, telefone, celular, cep,endereco,
                         numero, complemento, bairro, cidade, estado )
                    VALUES
                        (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco,
                        @numero, @complemento, @bairro, @cidade, @estado );";

                    MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                    execcmd.Parameters.AddWithValue("@nome", obj.nome);
                    execcmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                    execcmd.Parameters.AddWithValue("@email", obj.email);
                    execcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                    execcmd.Parameters.AddWithValue("@celular", obj.celular);
                    execcmd.Parameters.AddWithValue("@cep", obj.cep);
                    execcmd.Parameters.AddWithValue("@endereco", obj.endereco);
                    execcmd.Parameters.AddWithValue("@numero", obj.numero);
                    execcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                    execcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                    execcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                    execcmd.Parameters.AddWithValue("@estado", obj.estado);

                    conn.Open();
                    execcmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Fornecedor " + obj.nome + " cadastrado com sucesso!");



                }
                catch (Exception erro)
                {

                    MessageBox.Show("Cliente NÃO cadastrado! Valide as informações!" + erro);
                }
        }

        #endregion

        #region ListaFornecedores

        public DataTable ListaFornecedores()
        {
            try
            {
                DataTable tablefornecedor = new DataTable();

                string cCmdSql = "SELECT * FROM tb_fornecedores;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablefornecedor);

                return tablefornecedor;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de fornecedores! " + erro);
                return null;
            }
        }

        #endregion

    }
}
