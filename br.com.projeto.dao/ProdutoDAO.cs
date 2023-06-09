﻿using MySql.Data.MySqlClient;
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
    public class ProdutoDAO
    {

        private MySqlConnection conn;

        public ProdutoDAO() 
        {
            this.conn = new ConnectionFactory().Getconnection();
        }

        #region CadastrarProduto

        public void CadastrarProduto(Produto obj)
        {
            try
            {

                string cCmdSql = @"INSERT INTO 
                                        tb_produtos 
                                            (descricao, preco, qtd_estoque, for_id) 
                                        values 
                                            (@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@descricao",       obj.descricao);
                execcmd.Parameters.AddWithValue("@preco",           obj.preco);
                execcmd.Parameters.AddWithValue("@qtd_estoque",     obj.qtd_estoque);
                execcmd.Parameters.AddWithValue("@for_id",          obj.for_id);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Produto " + obj.descricao + " cadstrado com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, favor validar as informações. " + erro);
            }
        }

        #endregion

        #region AlterarProduto

        public void AlterarProduto(Produto obj)
        {
            try
            {

                string cCmdSql = @"UPDATE 
                                        tb_produtos 
                                    SET
                                            descricao=@descricao, preco=@preco, 
                                             qtd_estoque=@qtd_estoque, for_id=@for_id
                                    WHERE
                                             id=@id;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@descricao", obj.descricao);
                execcmd.Parameters.AddWithValue("@preco", obj.preco);
                execcmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                execcmd.Parameters.AddWithValue("@for_id", obj.for_id);

                execcmd.Parameters.AddWithValue("@id", obj.id);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Produto " + obj.descricao + " alterado com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, favor validar as informações. " + erro);
            }
        }

        #endregion

        #region ExcluirProduto

        public void ExcluirProduto(Produto obj)
        {
            try
            {

                string cCmdSql = @"DELETE FROM 
                                        tb_produtos 
                                    WHERE
                                             id=@id;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@id", obj.id);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Produto excluido com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, favor validar as informações. " + erro);
            }
        }

        #endregion


        #region ListarProdutos

        public DataTable ListarProdutos()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string cCmdSql = @"SELECT p.id as 'Código',
                                          p.descricao as 'Descrição',
                                          p.preco as 'Preço',
                                          p.qtd_estoque as 'Qtd Estoque',
                                          f.nome as 'Fornecedor'
                                    FROM tb_produtos as p
                                    JOIN tb_fornecedores as f
                                         on (p.for_id=f.id);";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tabelaProduto);

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de clientes! " + erro);
                return null;
            }
        }

        #endregion

        #region BuscaProdutoNome

        public DataTable BuscaProdutoNomeAprx(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string cCmdSql = @"SELECT p.id as 'Código',
                                          p.descricao as 'Descrição',
                                          p.preco as 'Preço',
                                          p.qtd_estoque as 'Qtd Estoque',
                                          f.nome as 'Fornecedor'
                                    FROM tb_produtos as p
                                    JOIN tb_fornecedores as f
                                         on (p.for_id=f.id) 
                                   WHERE p.descricao like @descricao;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@descricao", descricao);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tabelaProduto);

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de fornecedores! " + erro);
                return null;
            }
        }

        #endregion

        #region BuscaProdutoNome

        public DataTable BuscaProdutoNome(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string cCmdSql = @"SELECT p.id as 'Código',
                                          p.descricao as 'Descrição',
                                          p.preco as 'Preço',
                                          p.qtd_estoque as 'Qtd Estoque',
                                          f.nome as 'Fornecedor'
                                    FROM tb_produtos as p
                                    JOIN tb_fornecedores as f
                                         on (p.for_id=f.id) 
                                   WHERE p.descricao=@descricao;";
                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tabelaProduto);

                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de Produtos! " + erro);
                return null;
            }
        }

        #endregion

        #region RetornaProdutoPorCod

        public Produto RetornaProdutoPorCod(int id)
        {
            try
            {

                

                string cCmdSql = @"SELECT * FROM tb_produtos where id = @id";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                execcmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                MySqlDataReader rs = execcmd.ExecuteReader();

                if (rs.Read())
                {

                    Produto p = new Produto();

                    p.id         = rs.GetInt32("id");
                    p.descricao  = rs.GetString("descricao");
                    p.preco      = rs.GetDecimal("preco");

                    conn.Close();

                return p;
                }


                return null;

            }
            catch (Exception erro)
            {

                MessageBox.Show("A aplicação nos retornou um erro, por gentileza, valide as informações: " + erro);
                return null;

            }
        }

        #endregion

        #region BaixaEstoque

        public void BaixaEstoque(int idproduto, int qtdestoque)
        {
            try
            {

                string cCmdSql = "UPDATE tb_produtos SET qtd_estoque = @qtd WHERE id = @id;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@qtd", qtdestoque);
                execcmd.Parameters.AddWithValue("@id", idproduto);

                conn.Open();

                execcmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, valide as infomações: " + erro);
                conn.Close();
            }
        }

        #endregion

        #region RetornaEstoqueAtualPrd

        public int RetornaEstoqueAtualPrd(int idproduto)
        {
            try
            {

                string cCmdSql = @"SELECT qtd_estoque FROM tb_produtos WHERE id=@id";
                int qtd_estoque = 0;

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@id", idproduto);

                conn.Open();

                MySqlDataReader rs = execcmd.ExecuteReader();

                if(rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");

                    conn.Close();
                }

                return qtd_estoque;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, valide as informações: " + erro);
                return 0;
            }
        }

        #endregion
    }
}
