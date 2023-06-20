using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.model
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public Decimal preco { get; set; }
        public int qtd_estoque { get; set; }
        public int for_id { get; set; }
    }
}
