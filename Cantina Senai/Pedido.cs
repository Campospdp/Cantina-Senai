using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Senai
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public string Itens { get; set; }
        public string FormaPagamento { get; set; }
        public string ParaViagem { get; set; }
        public string Status { get; set; } = "Aguardando";
        public string Hora { get; set; } = DateTime.Now.ToShortTimeString();

        public override string ToString()
        {
            return $"{Cliente} - {Itens} - {ParaViagem} - {Status} - {Hora}";
        }

        public static class BaseDePedidos
        {
            public static List<Pedido> Pedidos = new List<Pedido>();
        }
    }
}
