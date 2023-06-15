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
            if (txtnomepesquisar.Text.Length == 0)
            {
                FornecedorDAO dao = new FornecedorDAO();

                tabelafornecedor.DataSource = dao.ListaFornecedores();
            }
            else
            {
                return;
            }
        }
    }
}
