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
               if (pedidoSelecionado.Status != "Pronto")
                {
                    MessageBox.Show("Este pedido ainda não foi entregue pela cozinha.");
                    return;
                }

                pedidoSelecionado.Status = "Entregue";
                listEntregues.Items.Add(pedidoSelecionado);
                listPedido.Items.Remove(pedidoSelecionado);
                Serializar.Salvar(BaseDePedidos.Pedidos);
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listPedido.Items.Clear();
            BaseDePedidos.Pedidos = Serializar.Carregar();
            foreach (var pedido in BaseDePedidos.Pedidos)
            {
                if (pedido.Status != "Entregue")
                    listPedido.Items.Add(pedido);
                else
                    listEntregues.Items.Add(pedido);
            }
        }

        private void btnTelaVendas_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is TelaVendas)
                {
                    f.Focus();
                    return;
                }
            }

            TelaVendas novaJanela = new TelaVendas();
            novaJanela.Show();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Cozinha)
                {
                    f.Close(); 
                    break;
                }
            }

            Cozinha novaJanela = new Cozinha();
            novaJanela.Show();
        }
    }
}