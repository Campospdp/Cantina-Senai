using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina_Senai
{
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            foreach (var item in Pedido.BaseDePedidos.Pedidos)
            {
                if (item.Status == "Pronto" || item.Status == "Preparando")
                {
                    listPreparando.Items.Insert(0, item.Cliente);
                }
                else if (item.Status == "Entregue")
                {
                    listPronto.Items.Insert(0, item.Cliente);
                }
            }
        }

        private void buttonVendas_Click(object sender, EventArgs e)
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
    }
}