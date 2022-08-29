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
        public string listarProduto() 
        {
            return "Autor: " + Autor +
                "\nEditora: " + Editora +
                "\nEdição: " + Edicao;
        }
    }
}
