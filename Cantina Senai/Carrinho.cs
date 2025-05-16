using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Senai
{
    public class Carrinho
    {
        private List<Produto> produtos = new List<Produto>();

        public void Adicionar(Produto novoProduto)
        {
            var existente = produtos.FirstOrDefault(p => p.Nome == novoProduto.Nome);
            if (existente != null)
            {
                existente.Quantidade += novoProduto.Quantidade;
            }
            else
            {
                produtos.Add(novoProduto);
            }
        }

        public void Remover(Produto produto)
        {
            produtos.Remove(produto);
        }
        public void Limpar()
        {
            produtos.Clear();
        }
        public double Total()
        {
            return produtos.Sum(p => p.Total);
        }
        public List<Produto> ObterProdutos()
        {
            return produtos;
        }
    }
}