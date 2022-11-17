using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class CarrinhoDeCompras : Produto
    {
        List<Produto> carrinho = new List<Produto>();

        public CarrinhoDeCompras(int codigo, string nome, double preco) : base(codigo, nome, preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public CarrinhoDeCompras()
        {

        }

   

        public void AddProdutos(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoveProdutos(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public double TotalPreco()
        {
            double somaPreco = 0.0;

            foreach(Produto produto in carrinho)
            {
                somaPreco += produto.Preco;
            }
            return somaPreco;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Produto produto in carrinho)
            {
                sb.Append(produto + "\n");
            }

            return sb.ToString();
        }
        
    }
}
