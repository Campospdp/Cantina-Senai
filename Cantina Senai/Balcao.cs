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
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = "Pedido Finalizado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string[] linha = { textBox1.Text, "Pendente", DateTime.Now.ToString("dd/MM/yyyy HH:mm") };
                ListViewItem item = new ListViewItem(linha);
                listView1.Items.Add(item);
                textBox1.Clear();
            }
        }
    }
}



//listBox3.SelectedItems[0].SubItems[1].Text = "Pedido Finalizado";
