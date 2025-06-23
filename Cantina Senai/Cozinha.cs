using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_Senai
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
            listCozinha.DisplayMember = "ToString";
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            listCozinha.Items.Clear();
            Pedido.BaseDePedidos.Pedidos = Serializar.Carregar();

            foreach (var pedido in Pedido.BaseDePedidos.Pedidos)
            {
                if (pedido.Status == "Preparando" && ContemItemChapa(pedido.Itens))
                {
                    listCozinha.Items.Add(pedido);
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

        private void btnEntregarChapa_Click_1(object sender, EventArgs e)
        {
            if (listCozinha.SelectedItem is Pedido pedidoSelecionado)
            {
                pedidoSelecionado.Status = "Pronto";
                Serializar.Salvar(Pedido.BaseDePedidos.Pedidos);
                listCozinha.Items.Remove(pedidoSelecionado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Balcao)
                {
                    f.Close();
                    break;
                }
            }

            Balcao novaJanela = new Balcao();
            novaJanela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Chamada)
                {
                    f.Close();
                    break;
                }
            }

            Chamada novaJanela = new Chamada();
            novaJanela.Show();
        }
    }
}
