using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Senai
{
    public partial class Form1 : Form
    {

        private Carrinho carrinho;
        public Form1()
        {
            InitializeComponent();
            carrinho = new Carrinho();
            txtValorPago.Visible = false;
            txtTroco.Visible =  false;
            labelV.Visible = false;
            labelT.Visible = false;

            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Preço";
            listBox2.DisplayMember = "ToString";

            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo", Preco = 3.50 });
            listBox1.Items.Add(new Produto { Nome = "Coxinha", Preco = 5 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne", Preco = 6 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo", Preco = 5.50 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer Simples", Preco = 8 });
            listBox1.Items.Add(new Produto { Nome = "Hambúrguer com Queijo", Preco = 9 });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo", Preco = 12 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata", Preco = 4.50 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural", Preco = 4 });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral", Preco = 2.50 });

            cmbPagamento.Items.AddRange(new string[] { "Dinheiro", "Débito", "Crédito", "Pix", "VR", "VA" });
            cmbViagem.Items.Add("Sim");

            btnQuantidade.Minimum = 1;
            btnQuantidade.Value = 1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produtoSelecionado)
            {
                int quantidade = (int)btnQuantidade.Value;

                var novoProduto = new Produto
                {
                    Nome = produtoSelecionado.Nome,
                    Preco = produtoSelecionado.Preco,
                    Quantidade = quantidade
                };

                carrinho.Adicionar(novoProduto);

                AtualizarListBox2();
                AtualizarTotal();
                btnQuantidade.Value = 1;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Produto produto)
            {
                carrinho.Remover(produto);
                AtualizarListBox2();
                AtualizarTotal();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            double total = carrinho.Total();
            string formaPagamento = cmbPagamento.SelectedItem?.ToString();
            string nomeCliente = txtnomeCliente.Text;
            string paraViagem = cmbViagem.SelectedItem?.ToString() ?? "Não";

            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Por favor, insira o nome do cliente.");
                return;
            }

            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione a forma de pagamento.");
                return;
            }

            if (formaPagamento == "Dinheiro")
            {
                if (!double.TryParse(txtValorPago.Text, out double valorPago))
                {                    
                    MessageBox.Show("Valor recebido inválido.");
                    return;
                }
                else
                {
                    double troco = valorPago - total;
                    txtTroco.Text = troco.ToString("F2");
                    if (valorPago < total)
                    {
                        MessageBox.Show($"Valor insuficiente");
                        return;
                    }
                        
                }   
            }
            

            string extrato = $"Cliente: {nomeCliente}\n" +
                             $"Total: R${total:F2}\n" +
                             $"Forma de Pagamento: {formaPagamento}\n" +
                             $"Para Viagem: {paraViagem}\n" +
                             $"Data e Hora: {DateTime.Now}\n";
            MessageBox.Show(extrato, "Extrato do Pedido");
            
            DateTime agora = DateTime.Now;

            cmbViagem.SelectedIndex = -1;
            cmbPagamento.SelectedIndex = -1;
            txtTroco.Clear();
            txtValorPago.Clear();
            txtnomeCliente.Clear();
            carrinho.Limpar();
            AtualizarListBox2();
            AtualizarTotal();
        }
        
        private void AtualizarListBox2()
        {
            listBox2.Items.Clear();
            foreach (var item in carrinho.ObterProdutos())
            {
                listBox2.Items.Add(item);
            }
        }
        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R${carrinho.Total():F2}";
        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool dinheiro = cmbPagamento.SelectedItem?.ToString() == "Dinheiro";
            txtValorPago.Visible = dinheiro;
            txtTroco.Visible = dinheiro;
            labelV.Visible = dinheiro;
            labelT.Visible = dinheiro;
        }
    }
}