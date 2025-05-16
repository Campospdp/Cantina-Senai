using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Senai
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total => Preco * Quantidade;
        public override string ToString()
        {
            return $"{Quantidade} - {Nome} - R${Total:F2}";
        }
    }
}