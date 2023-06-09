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
    public class FuncionarioDAO
    {
        private MySqlConnection conn;

        public FuncionarioDAO()
        {
            this.conn = new ConnectionFactory().Getconnection();

        }

        #region Cadastrar Funcionario

        public void CadastrarFuncionario( Funcionario obj )
        {
            try
            {

                string cCmdSql = @"INSERT INTO tb_funcionarios 
                                        (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone,
                                        celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                    values 
                                        (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular,
                                        @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // Conexão
                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome",            obj.nome);
                execcmd.Parameters.AddWithValue("@rg",              obj.rg);
                execcmd.Parameters.AddWithValue("@cpf",             obj.cpf);
                execcmd.Parameters.AddWithValue("@senha",           obj.senha);
                execcmd.Parameters.AddWithValue("@cargo",           obj.cargo);
                execcmd.Parameters.AddWithValue("@nivel_acesso",    obj.nivel_acesso);
                execcmd.Parameters.AddWithValue("@email",           obj.email);
                execcmd.Parameters.AddWithValue("@telefone",        obj.telefone);
                execcmd.Parameters.AddWithValue("@celular",         obj.celular);
                execcmd.Parameters.AddWithValue("@cep",             obj.cep);
                execcmd.Parameters.AddWithValue("@endereco",        obj.endereco);
                execcmd.Parameters.AddWithValue("@numero",          obj.numero);
                execcmd.Parameters.AddWithValue("@complemento",     obj.complemento);
                execcmd.Parameters.AddWithValue("@bairro",          obj.bairro);
                execcmd.Parameters.AddWithValue("@cidade",          obj.cidade);
                execcmd.Parameters.AddWithValue("@estado",          obj.estado);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Funcionário " + obj.nome + " cadastrado com sucesso!");


            }
            catch (Exception erro)
            {

                MessageBox.Show("Obtivemos um erro, por gentileza avalie, ou contate o suporte: " + erro);
            }
        }

        #endregion

        #region AlterarFuncionario

        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                string cCmdSql = @"UPDATE tb_funcionarios set
                                        nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo,
                                        nivel_acesso=@nivel_acesso, telefone=@telefone,
                                        celular=@celular, cep=@cep, endereco=@endereco, numero=@numero,
                                        complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                                    WHERE
                                        id=@codigo";
                // Conexão
                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome", obj.nome);
                execcmd.Parameters.AddWithValue("@rg", obj.rg);
                execcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                execcmd.Parameters.AddWithValue("@senha", obj.senha);
                execcmd.Parameters.AddWithValue("@cargo", obj.cargo);
                execcmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                execcmd.Parameters.AddWithValue("@codigo", obj.codigo);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Funcionário " + obj.nome + " cadastrado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, por favor, analise: " + erro);
            }
        }


        #endregion

        #region ExcluirFuncionario

        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string cCmdSql = @"DELETE 
                                    FROM tb_funcionarios 
                                   WHERE 
                                    id=@codigo";
                // Conexão
                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@codigo", obj.codigo);
                execcmd.Parameters.AddWithValue("@nome", obj.nome);


                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Funcionário " + obj.nome + " excluído com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, por favor, analise: " + erro);
            }
        }


        #endregion

        #region ListarFuncionario

        public DataTable ListarFuncionario()
        {
            try
            {
                DataTable tablefuncionario = new DataTable();

                string cCmdSql = "SELECT * FROM tb_funcionarios;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablefuncionario);

                return tablefuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de funcionarios! " + erro);
                return null;
            }
        }

        #endregion


        #region PesquisarFuncionario

        public DataTable PesquisarFuncionario( string nome)
        {
            try
            {
                DataTable tablefuncionario = new DataTable();

                string cCmdSql = "SELECT * FROM tb_funcionarios WHERE nome=@nome;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome", nome);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablefuncionario);

                return tablefuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de funcionarios! " + erro);
                return null;
            }
        }

        #endregion

        #region PesquisarPorNome

        public DataTable PesquisarPorNome(string nome)
        {
            try
            {
                DataTable tablefuncionario = new DataTable();

                string cCmdSql = "SELECT * FROM tb_funcionarios WHERE nome LIKE @nome;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome", nome);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablefuncionario);

                return tablefuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de funcionarios! " + erro);
                return null;
            }
        }

        #endregion
    }
}
