﻿using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
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
                                            (@descricao, @preco, @qtdEstoque, @for_id)";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@descricao",       obj.descricao);
                execcmd.Parameters.AddWithValue("@preco",           obj.preco);
                execcmd.Parameters.AddWithValue("@qtd_estoque",     obj.qtdEstoque);
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

    }
}
