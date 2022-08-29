using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            Cd cd = new Cd();
            Dvd dvd = new Dvd();

            int n;
            do
            {
                Console.WriteLine("1 - Livro\n2 - CD\n3 - DVD\n4 - Sair");
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                    livro = new Livro();
                    livro.comprar(1);
                }
                else if (n == 2)
                {
                    cd = new Cd();
                    cd.listarProduto();
                }
                else if (n == 3)
                {
                    dvd = new Dvd();
                }
                else if (n == 0)
                {
                    Console.WriteLine("Saiu");
                }
                //===============================
                Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                int m = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Cadastro");
                }
                if (n == 2)
                {

                }
                if (n == 3)
                {

                }

                if (n == 4)
                {

                }
                if (n == 5)
                {

                }
                if (n == 6)
                {

                }
            }
            while (n != 0);
            
        }
    }
}
