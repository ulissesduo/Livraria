using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livro : Produto
    {
        private string autor;
        private string editora;
        private string edicao;

        public Livro() 
        {
        
        }

        public Livro(string autor, string editora, string edicao, string descricao, string genero, int estoquedisponivel, double precocusto, double precovenda) 
            : base(descricao,genero,estoquedisponivel,precocusto,precovenda) 
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        public string Edicao
        {
            get { return edicao; }
            set { edicao = value; }
        }
        public override void comprar(int qtde)
        {
            base.comprar(qtde);
        }
        public override void vender(int qtde)
        {
            base.vender(qtde);
        }
        public override void calcularPrecoVenda()
        {
            base.calcularPrecoVenda();
        }
        public string listarProduto() 
        {
            return "Descrição: " + Descricao +
                "\nGênero: " + Genero +
                "\nEstoque disponível: " + Estoque +
                "\nPreço de custo: " + getPrecoCusto +
                "\nPreço de venda: " + Venda +
                "\nAutor: " + Autor +
                "\nEditora: " + Editora +
                "\nEdição: " + Edicao;
        }
    }
}
