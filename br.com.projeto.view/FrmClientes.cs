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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            tabelacliente.DefaultCellStyle.ForeColor = Color.Black;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelacliente.DataSource = dao.ListarFuncionario();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Cliente obj     = new Cliente();
            obj.nome        = txtnome.Text;
            obj.rg          = txtrg.Text;
            obj.cpf         = txtcpf.Text;
            obj.email       = txtemail.Text;
            obj.celular     = txtcelular.Text;
            obj.telefone    = txttelefone.Text;
            obj.endereco    = txtendereco.Text;
            obj.numero      = int.Parse(txtnumero.Text);
            obj.bairro      = txtbairro.Text;
            obj.cidade      = txtcidade.Text;
            obj.estado      = cbuf.Text;
            obj.cep         = txtcep.Text;
            obj.complemento = txtcomplemento.Text;
        
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabelacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text =        tabelacliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text =          tabelacliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text =            tabelacliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text =           tabelacliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text =         tabelacliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text =      tabelacliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text =       tabelacliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text =           tabelacliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text =      tabelacliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text =        tabelacliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text =   tabelacliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text =        tabelacliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text =        tabelacliente.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text =             tabelacliente.CurrentRow.Cells[13].Value.ToString();


        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtnomepesquisar.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelacliente.DataSource = dao.BuscarClienteNome(nome);

            if(tabelacliente.Rows.Count <= 0)
            {
                tabelacliente.DataSource = dao.ListarClientes();

            }

        }

        private void txtnomepesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtnomepesquisar + "%";
            
            ClienteDAO dao = new ClienteDAO();

            tabelacliente.DataSource = dao.ListarClientesNome(nome);
        }

        private void Pesquisar_Click_1(object sender, EventArgs e)
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

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
