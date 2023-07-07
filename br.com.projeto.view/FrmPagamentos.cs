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
    public partial class FrmPagamentos : Form
    {

        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();

        public FrmPagamentos(Cliente cliente, DataTable carrinho)
        {

            this.cliente = cliente;
            this.carrinho = carrinho;

            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
