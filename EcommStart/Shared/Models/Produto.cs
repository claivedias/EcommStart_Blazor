using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommStart.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome{ get; set; } = string.Empty;
        public double Preco { get; set; }
        public double Quantidade { get;set; }
        public string Imagem { get; set; } = "";
    }
}
