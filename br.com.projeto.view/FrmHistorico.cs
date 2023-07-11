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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {

            DateTime datainicio, datafim;

            datainicio   = Convert.ToDateTime(dtinicio.Value.ToString("yyyy-MM-dd"));
            datafim      = Convert.ToDateTime(dtinicio.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            dthistorico.DataSource = dao.listaVendasPorPeriodo(datainicio, datafim);



        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {

            VendaDAO dao = new VendaDAO();

            dthistorico.DataSource = dao.listarVendas();
            dthistorico.DefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
