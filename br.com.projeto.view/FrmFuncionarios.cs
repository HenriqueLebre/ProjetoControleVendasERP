using MySqlX.XDevAPI;
using ProjetoControleVendas.br.com.projeto.dao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void cbnivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome            = txtnome.Text;
            obj.rg              = txtrg.Text;
            obj.cpf             = txtcpf.Text;
            obj.email           = txtemail.Text;
            obj.senha           = txtSenha.Text;
            obj.nivel_acesso    = cbnivel.SelectedItem.ToString();
            obj.telefone        = txttelefone.Text;
            obj.celular         = txtcelular.Text;
            obj.cep             = txtcep.Text;
            obj.endereco        = txtendereco.Text;
            obj.numero          = int.Parse(txtnumero.Text);
            obj.bairro          = txtbairro.Text;
            obj.cidade          = txtcidade.Text;
            obj.estado          = cbuf.SelectedItem.ToString();
            obj.cargo           = txtCargo.Text;


            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(obj);

            tabelafuncionario.DataSource = dao.ListarFuncionario();


        }

        private void tabelacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load_1(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.ListarFuncionario();

        }

        private void tabelafuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text          = tabelafuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text            = tabelafuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text              = tabelafuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text             = tabelafuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text           = tabelafuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text           = tabelafuncionario.CurrentRow.Cells[5].Value.ToString();
            txtCargo.Text           = tabelafuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text            = tabelafuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text        = tabelafuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text         = tabelafuncionario.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text             = tabelafuncionario.CurrentRow.Cells[10].Value.ToString();
            txtnumero.Text          = tabelafuncionario.CurrentRow.Cells[11].Value.ToString();
            txtcomplemento.Text     = tabelafuncionario.CurrentRow.Cells[12].Value.ToString();
            txtbairro.Text          = tabelafuncionario.CurrentRow.Cells[13].Value.ToString();
            cbuf.Text               = tabelafuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text          = tabelafuncionario.CurrentRow.Cells[15].Value.ToString();

            tabfuncionarios.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();

            dao.ExcluirFuncionario(obj);

            tabelafuncionario.DataSource = dao.ListarFuncionario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.senha = txtSenha.Text;
            obj.cargo = txtCargo.Text;
            obj.nivel_acesso = cbnivel.SelectedItem.ToString();
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.SelectedItem.ToString();

            obj.codigo = int.Parse(txtcodigo.Text);


            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(obj);

            tabelafuncionario.DataSource = dao.ListarFuncionario();
        }

        private void btnpesquisarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtnomepesquisar.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelafuncionario.DataSource = dao.PesquisarFuncionario(nome);

            if(tabelafuncionario.Rows.Count == 0 || txtnomepesquisar.Text == string.Empty) 
            {
                tabelafuncionario.DataSource = dao.ListarFuncionario();
            }

        }

        private void txtnomepesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtnomepesquisar.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelafuncionario.DataSource = dao.PesquisarPorNome(nome);
        }

        private void btnpesquisarcep_Click(object sender, EventArgs e)
        {
            string cCep = Regex.Replace(txtcep.Text, "[^0-9a-zA-Z]+", "");
            string uXml = "https://viacep.com.br/ws/" + cCep + "/xml/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string xmlData = client.GetStringAsync(uXml).Result;

                    DataSet dados = new DataSet();
                    dados.ReadXml(new StringReader(xmlData));

                    if (dados.Tables.Count > 0 && dados.Tables[0].Rows.Count > 0)
                    {
                        txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                        txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                        txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                        txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                        cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados dados para o CEP informado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao obter os dados do CEP: " + ex.Message);
                }
            }
        }
    }
}
