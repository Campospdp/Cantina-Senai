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
                Serializar.Salvar(BaseDePedidos.Pedidos);
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listPedido.Items.Clear();
            BaseDePedidos.Pedidos = Serializar.Carregar();

            foreach (var pedido in BaseDePedidos.Pedidos)
            {
                if (pedido.Status == "Entregue")
                {
                    listEntregues.Items.Add(pedido);
                }
                else if (pedido.Status == "Pronto" || !ContemItemChapa(pedido.Itens))
                {
                    listPedido.Items.Add(pedido);
                }
            }
        }
        private bool ContemItemChapa(string itens)
        {
            string[] chapa = new string[]
            {
                "Pastel de Carne",
                "Pastel de Queijo",
                "Hambúrguer Simples",
                "Hambúrguer com Queijo",
                "X-Tudo"
            };

            foreach (var item in chapa)
            {
                if (itens.Contains(item))
                    return true;
            }

            return false;
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

        private void btnChamada_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Chamada)
                {
                    f.Focus();
                    return;
                }
            }

            Chamada novaJanela = new Chamada();
            novaJanela.Show();
        }
    }
}