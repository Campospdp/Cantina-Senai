using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cantina_Senai.Pedido;

namespace Cantina_Senai
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            if (listPedido.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "Entregue";
                listEntregues.Items.Add(pedidoSelecionado);
                listPedido.Items.Remove(pedidoSelecionado);
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listPedido.Items.Clear();
            foreach (var pedido in BaseDePedidos.Pedidos)
            {
                listPedido.Items.Add(pedido);
            }
        }

        private void btnTelaVendas_Click(object sender, EventArgs e)
        {
            TelaVendas minhaNovaJanela = new TelaVendas();
            minhaNovaJanela.Show();
        }
    }
}
