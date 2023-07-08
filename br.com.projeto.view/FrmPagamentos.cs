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
    public partial class FrmPagamentos : Form
    {

        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;

        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {

            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;

            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

            try
            {
                decimal v_dinheiro, v_cartao, v_pix, v_troco, totalpago, total;

                v_dinheiro = decimal.Parse(textdinheiro.Text);
                v_cartao = decimal.Parse(textCartao.Text);
                v_pix = decimal.Parse(textpix.Text);
                total = decimal.Parse(texttotal.Text);


                totalpago = v_dinheiro + v_cartao + v_pix;

                if(totalpago < total) 
                {

                    MessageBox.Show("O valor ainda não está quitado, informe o metódo de Pagamento!");

                }
                else
                {
                    v_troco = totalpago - total;

                    Venda vendas = new Venda();

                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total = total;
                    vendas.observacao = txtobs.Text;

                    VendaDAO vdao = new VendaDAO();
                    txttroco.Text = v_troco.ToString();

                    vdao.CadastraVenda(vendas);



                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();

                        item.venda_id   = vdao.RetornaIdUltVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd        = int.Parse(linha["Qtd"].ToString());
                        item.subtotal   = decimal.Parse(linha["Subtotal"].ToString());

                        ItemVendaDAO itemDAO = new ItemVendaDAO();
                        itemDAO.CadastraItemVenda(item);


                        //MessageBox.Show("Código " +  linha["Codigo"].ToString());
                        //MessageBox.Show("Produto" +  linha["Produto"].ToString());
                        //MessageBox.Show("Qtd" +      linha["Qtd"].ToString());
                        //MessageBox.Show("Preço" +    linha["Preço"].ToString());
                        //MessageBox.Show("Subtotal" + linha["Subtotal"].ToString());

                    }

                    MessageBox.Show("Venda realizada com sucesso!");

                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            txttroco.Text       = "0.00";
            textdinheiro.Text   = "0.00";
            textCartao.Text     = "0.00";
            textpix.Text        = "0.00";
            texttotal.Text      = "0.00";

        }
    }
}
