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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.EfetuaLogin(email, senha) == true) 
            {

                FrmMenu telaMenu = new FrmMenu();
                telaMenu.Show();

                this.Hide();

            }

        }
    }
}
