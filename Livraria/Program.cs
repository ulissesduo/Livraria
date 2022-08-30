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

            int qtd;
            int op = -1, opcao = -1;
            do
            {
                Console.WriteLine("1 - Livro\n2 - CD\n3 - DVD\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Digite o autor: ");
                                    string autor = Console.ReadLine();

                                    Console.WriteLine("Digite a editora: ");
                                    string editora = Console.ReadLine();

                                    Console.WriteLine("Digite a edição: ");
                                    string edicao = Console.ReadLine();

                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();

                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();

                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precocusto = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de venda: ");
                                    double precovenda = int.Parse(Console.ReadLine());

                                    livro = new Livro(autor, editora, edicao, descricao, genero, estoqueDisp, precocusto, precovenda);
                                    break;
                                case 2:
                                    Console.WriteLine("Digite a quantidade para compra: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    livro.comprar(qtd);
                                    break;
                                case 3:
                                    livro.calcularPrecoVenda();
                                    break;
                                case 4:
                                    Console.WriteLine("Digite a quantidade para venda: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    livro.vender(qtd);
                                    break;
                                case 5:
                                    livro.listarProduto();
                                    Console.WriteLine(livro.listarProduto());
                                    break;
                                default:
                                    Console.WriteLine("Inválido");
                                    break;
                            }
                        }
                        while (op != 0);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Nome do artista: ");
                                    string artista = Console.ReadLine();

                                    Console.WriteLine("Digite a gravadora: ");
                                    string gravadora = Console.ReadLine();

                                    Console.WriteLine("Digite o país de origem: ");
                                    string paisorigem = Console.ReadLine();

                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();

                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();

                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precocusto = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de venda: ");
                                    double precovenda = int.Parse(Console.ReadLine());

                                    cd = new Cd(artista,gravadora,paisorigem,descricao, genero, estoqueDisp, precocusto, precovenda);
                                    break;
                                case 2:
                                    Console.WriteLine("Digite a quantidade para compra: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    cd.comprar(qtd);
                                    break;
                                case 3:
                                    cd.calcularPrecoVenda();
                                    Console.WriteLine("CALCULAR PRECO CD");
                                    break;
                                case 4:
                                    Console.WriteLine("Digite a quantidade para venda: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    cd.vender(qtd);
                                    break;
                                case 5:
                                    cd.listarProduto();
                                    Console.WriteLine(cd.listarProduto());
                                    break;

                                default:
                                    Console.WriteLine("Inválido");
                                    break;
                            }
                        }
                        while (op != 0);
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Nome do diretor: ");
                                    string diretor = Console.ReadLine();

                                    Console.WriteLine("Digite a duração: ");
                                    string duracao = Console.ReadLine();

                                    Console.WriteLine("Qual é a censura: ");
                                    string censura = Console.ReadLine();

                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();

                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();

                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precocusto = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o preço de venda: ");
                                    double precovenda = int.Parse(Console.ReadLine());

                                    dvd = new Dvd(diretor,duracao,censura,descricao, genero, estoqueDisp, precocusto, precovenda);
                                    break;
                                case 2:
                                    Console.WriteLine("Digite a quantidade para compra: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    dvd.comprar(qtd);
                                    break;
                                case 3:
                                    Console.WriteLine("Cotação do dolar: ");
                                    double dollar = int.Parse(Console.ReadLine());
                                    dvd.calcularPrecoVenda(dollar);
                                    break;
                                case 4:
                                    Console.WriteLine("Digite a quantidade para venda: ");
                                    qtd = int.Parse(Console.ReadLine());
                                    dvd.comprar(qtd);
                                    break;
                                case 5:
                                    dvd.listarProduto();
                                    break;
                                default:
                                    Console.WriteLine("Inválido DVD");
                                    break;
                            }
                        }
                        while (op != 0);
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}
