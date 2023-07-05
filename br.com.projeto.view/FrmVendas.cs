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

        private void FrmVendas_Load(object sender, EventArgs e)
        {



        }
    }
}
