using ProjetoControleVendas.br.com.projeto.dao;
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
    public partial class FrmDetalhes : Form
    {
        int venda_id;

        public FrmDetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO dao = new ItemVendaDAO();

            tabeladetalhes.DataSource = dao.ListaItemPorVenda(venda_id);



        }
    }
}
