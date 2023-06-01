using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.model
{
    public class Helpers
    {
        public void LimparTela(Form Tela)
        {
            foreach (Control ctrPai in Tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if(ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if(ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty;
                            }
                        }
                    }

                }

            }
        }

    }
}
