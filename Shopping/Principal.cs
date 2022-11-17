using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Principal
    {
        static void Main(string[] args)
        {
            

            Produto p1 = new Produto(11, "Mouse", 22.0);
            Produto p2 = new Produto(22, "Teclado", 33.0);
            Produto p3 = new Produto(33, "Monitor", 77.0);
            Produto p4 = new Produto(44, "CPU", 99.0);

            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p5 = new Produto(codigo, nome, preco);

            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();





            carrinho.AddProdutos(p1);
            carrinho.AddProdutos(p2);
            carrinho.AddProdutos(p3);
            carrinho.AddProdutos(p4);
            Console.WriteLine();
            carrinho.AddProdutos(p5);

            carrinho.RemoveProdutos(p4);



            Console.WriteLine(carrinho);
            Console.WriteLine("Total R$: " + carrinho.TotalPreco());


            Console.ReadKey();  
        }
    }
}
