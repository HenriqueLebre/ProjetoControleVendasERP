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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();

            cbfornecedor.DataSource = f_dao.ListaFornecedores();

            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaproduto.DataSource = dao.ListarProdutos();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtcodigo.Text);
            obj.qtd_estoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();

            dao.CadastrarProduto(obj);

            new Helpers().LimparTela(this);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabelaproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaproduto.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaproduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaproduto.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaproduto.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaproduto.CurrentRow.Cells[4].Value.ToString();

            tabprodutos.SelectedTab = tabPage1;

        }
    }
}
