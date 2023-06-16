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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.celular = txtcelular.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.complemento = txtcomplemento.Text;

            FornecedorDAO dao = new FornecedorDAO();

            dao.CadastrarFornecedor(obj);

            tabelafornecedor.DataSource = dao.ListaFornecedores();

            new Helpers().LimparTela(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabelafornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();

            tabelafornecedor.DataSource = dao.ListaFornecedores();
        }

        // TESTANDO NOVA MANEIRA DE BUSCAR DADOS (PREFERI ASSIM)
        // TALVEZ COM UMA GRANDE QUANTIDADE DE DADOS, A TELA DEMORE PARA CARREGAR A TELA
        private void btnpesquisarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtnomepesquisar.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelafornecedor.DataSource = dao.BuscaFornecedorNome(nome);

            if (tabelafornecedor.Rows.Count == 0 || nome.Length == 0)
            {
                tabelafornecedor.DataSource = dao.ListaFornecedores();

            }

        }

        private void tabelafornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text =        tabelafornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text =          tabelafornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text =          tabelafornecedor.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text =         tabelafornecedor.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text =      tabelafornecedor.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text =       tabelafornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text =           tabelafornecedor.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text =      tabelafornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text =        tabelafornecedor.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text =   tabelafornecedor.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text =        tabelafornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text =        tabelafornecedor.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text =             tabelafornecedor.CurrentRow.Cells[12].Value.ToString();

            tabfornecedor.SelectedTab = tabPage1;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.celular = txtcelular.Text;
            obj.telefone = txttelefone.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;
            obj.cep = txtcep.Text;
            obj.complemento = txtcomplemento.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();

            dao.AlterarFornecedor(obj);

            tabelafornecedor.DataSource = dao.ListaFornecedores();

            new Helpers().LimparTela(this);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();

            dao.Excluirfornecedor(obj);

            tabelafornecedor.DataSource = dao.ListaFornecedores();

            new Helpers().LimparTela(this);
        }

        private void txtnomepesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtnomepesquisar.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelafornecedor.DataSource = dao.BuscaFornecedorNome(nome);
        }
    }
}
