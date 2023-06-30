using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    public class ClienteDAO
    {

        private MySqlConnection conn; 
        public ClienteDAO()
        {
              this.conn = new ConnectionFactory().Getconnection();
        }

        #region CadastrarCliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                string cCmdSql = @"INSERT INTO
                    tb_clientes
                        (nome, rg, cpf, email, telefone, celular, cep,endereco,
                         numero, complemento, bairro, cidade, estado )
                    VALUES
                        (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco,
                        @numero, @complemento, @bairro, @cidade, @estado );";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                execcmd.Parameters.AddWithValue("@nome",        obj.nome);
                execcmd.Parameters.AddWithValue("@rg",          obj.rg);
                execcmd.Parameters.AddWithValue("@cpf",         obj.cpf);
                execcmd.Parameters.AddWithValue("@email",       obj.email);
                execcmd.Parameters.AddWithValue("@telefone",    obj.telefone);
                execcmd.Parameters.AddWithValue("@celular",     obj.celular);
                execcmd.Parameters.AddWithValue("@cep",         obj.cep);
                execcmd.Parameters.AddWithValue("@endereco",    obj.endereco);
                execcmd.Parameters.AddWithValue("@numero",      obj.numero);
                execcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                execcmd.Parameters.AddWithValue("@bairro",      obj.bairro);
                execcmd.Parameters.AddWithValue("@cidade",      obj.cidade);
                execcmd.Parameters.AddWithValue("@estado",      obj.estado);

                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show( "Cliente " + obj.nome + " cadastrado com sucesso!" );



            }
            catch (Exception erro)
            {

                MessageBox.Show( "Cliente NÃO cadastrado! Valide as informações!" + erro );
            }
        }
        #endregion

        #region ListarClientes

        public DataTable ListarClientes()
        {
            try
            {
                DataTable tablecliente = new DataTable();

                string cCmdSql = "SELECT * FROM tb_clientes;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter( execcmd );

                da.Fill(tablecliente);

                return tablecliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de clientes! " + erro);
                return null;
            }
        }

        #endregion

        #region AlterarCliente

        public void AlterarCliente(Cliente obj)
        {
            try
            {
                string cCmdSql = @"UPDATE
                        tb_clientes
                     SET
                        nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep,endereco=@endereco,
                         numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                     WHERE 
                        id=@id";

                 MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                 execcmd.Parameters.AddWithValue("@nome",        obj.nome);
                 execcmd.Parameters.AddWithValue("@rg",          obj.rg);
                 execcmd.Parameters.AddWithValue("@cpf",         obj.cpf);
                 execcmd.Parameters.AddWithValue("@email",       obj.email);
                 execcmd.Parameters.AddWithValue("@telefone",    obj.telefone);
                 execcmd.Parameters.AddWithValue("@celular",     obj.celular);
                 execcmd.Parameters.AddWithValue("@cep",         obj.cep);
                 execcmd.Parameters.AddWithValue("@endereco",    obj.endereco);
                 execcmd.Parameters.AddWithValue("@numero",      obj.numero);
                 execcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                 execcmd.Parameters.AddWithValue("@bairro",      obj.bairro);
                 execcmd.Parameters.AddWithValue("@cidade",      obj.cidade);
                 execcmd.Parameters.AddWithValue("@estado",      obj.estado);
                 execcmd.Parameters.AddWithValue("@id",          obj.codigo);


                conn.Open();
                    execcmd.ExecuteNonQuery();
                conn.Close();

                    MessageBox.Show( "Cliente " + obj.nome + " alterado com sucesso!" );



            }
            catch (Exception erro)
            {

                MessageBox.Show( "Cliente NÃO alterado! Valide as informações!" + erro );
            }
        }

        #endregion


        #region ExcluirCliente

        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                string cCmdSql = @"DELETE FROM tb_clientes WHERE id=@id";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                execcmd.Parameters.AddWithValue("@id", obj.codigo);


                conn.Open();
                execcmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cliente " + obj.nome + " excluido com sucesso!");



            }
            catch (Exception erro)
            {

                MessageBox.Show("Cliente NÃO excluido! Valide as informações!" + erro);
            }
        }

        #endregion

        #region BuscarClienteNome
        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                DataTable tablecliente = new DataTable();

                string cCmdSql = "SELECT * FROM tb_clientes WHERE nome=@nome;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome", nome);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablecliente);

                return tablecliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de clientes! " + erro);
                return null;
            }
        }

        #endregion

        #region ListarClientesNome
        public DataTable ListarClientesNome(string nome)
        {
            try
            {
                DataTable tablecliente = new DataTable();

                string cCmdSql = "SELECT * FROM tb_clientes WHERE nome LIKE @nome;";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);

                execcmd.Parameters.AddWithValue("@nome", nome);

                conn.Open(); // Abre conexão

                execcmd.ExecuteNonQuery(); // executa instrução

                conn.Close(); // fecha conexão

                MySqlDataAdapter da = new MySqlDataAdapter(execcmd);

                da.Fill(tablecliente);

                return tablecliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Não foi possível carregar a lista de clientes! " + erro);
                return null;
            }
        }

        #endregion

        #region RetornaClientePorCpf

        public Cliente RetornaClientePorCpf( string cpf )
        {
            try
            {
                Cliente obj = new Cliente();

                string cCmdSql = @"SELECT * FROM tb_clientes WHERE cpf = @cpf";

                MySqlCommand execcmd = new MySqlCommand(cCmdSql, conn);
                execcmd.Parameters.AddWithValue("@cpf", cpf);

                conn.Open();
                MySqlDataReader rs = execcmd.ExecuteReader();

                if (rs.Read())
                {
                    obj.codigo  = rs.GetInt32("id");
                    obj.nome    = rs.GetString("nome");
                    obj.cep     = rs.GetString("cep");
                    obj.cidade  = rs.GetString("cidade");
                    obj.estado  = rs.GetString("uf");
                }

                conn.Close();

                return obj;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro na busca pelo cliente, valide as informações. Caso persista " +
                    "contate o suporte.");

                return null;
            }
        }

        #endregion

    }
}
