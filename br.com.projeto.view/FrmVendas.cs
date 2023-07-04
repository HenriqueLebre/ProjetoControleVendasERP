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

        public FrmVendas()
        {
            InitializeComponent();
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
    }
}
