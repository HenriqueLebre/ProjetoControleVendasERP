using ProjetoControleVendas.br.com.projeto.dao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class FrmVendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cDAO = new ClienteDAO();

        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, totalDeCompras;

        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Codigo",      typeof(int));
            carrinho.Columns.Add("Produto",     typeof(string));
            carrinho.Columns.Add("Qtd",         typeof(int));
            carrinho.Columns.Add("Preço",       typeof(decimal));
            carrinho.Columns.Add("Subtotal",    typeof(decimal));

            Produtos.DataSource = carrinho;

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cDAO.RetornaClientePorCpf(txtcpf.Text);
                
                txtnome.Text = cliente.nome;
                txtcep.Text = cliente.cep;
                txtcidade.Text = cliente.cidade;
                cbuf.Text = cliente.estado;

            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.RetornaProdutoPorCod(int.Parse(txtcodigo.Text));

                txtdesc.Text = p.descricao;
                txtpreco.Text = p.preco.ToString();
                txtqtd.Text = p.qtd_estoque.ToString();

            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;

                totalDeCompras += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);

                total.Text = totalDeCompras.ToString();

                qtdeitens.Text += qtd;

                txtcodigo.Clear();
                txtdesc.Clear();
                txtqtd.Clear();
                txtpreco.Clear();

                txtcodigo.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código do Produto!");
            }
        }

        private void btnrmvitem_Click(object sender, EventArgs e)
        {

            decimal subproduto = decimal.Parse(Produtos.CurrentRow.Cells[4].Value.ToString());

            int indice = Produtos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);

            carrinho.AcceptChanges();

            totalDeCompras -= subproduto;

            total.Text = totalDeCompras.ToString();

            MessageBox.Show("Produto removido do carrinho!");

        }

        private void btnpgto_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);

            FrmPagamentos tela = new FrmPagamentos(cliente, carrinho, dataatual);

            tela.texttotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();


        }
    }
}
