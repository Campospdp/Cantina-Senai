using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cantina_Senai.Pedido;

namespace Cantina_Senai
{
    public partial class TelaVendas : Form
    {

        private Carrinho carrinho;
        public TelaVendas()
        {
            InitializeComponent();
            carrinho = new Carrinho();
            txtValorPago.Visible = false;
            txtTroco.Visible = false;
            labelV.Visible = false;
            labelT.Visible = false;

            listCardapio.DisplayMember = "Nome";
            listCardapio.ValueMember = "Preço";
            listCarrinho.DisplayMember = "ToString";

            listCardapio.Items.Add(new Produto { Nome = "Pão de Queijo", Preco = 3.50 });
            listCardapio.Items.Add(new Produto { Nome = "Coxinha", Preco = 5 });
            listCardapio.Items.Add(new Produto { Nome = "Pastel de Carne", Preco = 6 });
            listCardapio.Items.Add(new Produto { Nome = "Pastel de Queijo", Preco = 5.50 });
            listCardapio.Items.Add(new Produto { Nome = "Hambúrguer Simples", Preco = 8 });
            listCardapio.Items.Add(new Produto { Nome = "Hambúrguer com Queijo", Preco = 9 });
            listCardapio.Items.Add(new Produto { Nome = "X-Tudo", Preco = 12 });
            listCardapio.Items.Add(new Produto { Nome = "Refrigerante Lata", Preco = 4.50 });
            listCardapio.Items.Add(new Produto { Nome = "Suco Natural", Preco = 4 });
            listCardapio.Items.Add(new Produto { Nome = "Água Mineral", Preco = 2.50 });

            cmbPagamento.Items.AddRange(new string[] { "Dinheiro", "Débito", "Crédito", "Pix", "VR", "VA" });
            cmbViagem.Items.Add("Sim");

            btnQuantidade.Minimum = 1;
            btnQuantidade.Value = 1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listCardapio.SelectedItem is Produto produtoSelecionado)
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
            if (listCarrinho.SelectedItem is Produto produto)
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

            if (listCarrinho.Items.Count <= 0)
            {
                MessageBox.Show("Escolha um item no cardápio");
                return;
            }


            string extrato = $"Cliente: {nomeCliente}\n" +
                             $"Total: R${total:F2}\n" +
                             $"Forma de Pagamento: {formaPagamento}\n" +
                             $"Para Viagem: {paraViagem}\n" +
                             $"Data e Hora: {DateTime.Now}\n";
            MessageBox.Show(extrato, "Extrato do Pedido");

            DateTime agora = DateTime.Now;

            Pedido novoPedido = new Pedido
            {
                Cliente = nomeCliente,
                FormaPagamento = formaPagamento,
                ParaViagem = paraViagem,
                Hora = agora.ToShortTimeString(),
                Itens = string.Join(" ,", carrinho.ObterProdutos().Select(p => $"{p.Quantidade} x {p.Nome} - R$ {p.Preco * p.Quantidade:F2}"))
            };

            BaseDePedidos.Pedidos.Add(novoPedido);

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
            listCarrinho.Items.Clear();
            foreach (var item in carrinho.ObterProdutos())
            {
                listCarrinho.Items.Add(item);
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

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Balcao minhaNovaJanela = new Balcao();
            minhaNovaJanela.Show();
        }
    }
}