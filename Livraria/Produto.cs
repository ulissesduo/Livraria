using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Produto
    {
        private string descricao;
        private string genero;
        private int estoqueDisponível;
        private double precoCusto;
        private double precoVenda;

        public string Descricao 
        {
             get { return descricao; }
            set { descricao = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public int Estoque
        {
            get { return estoqueDisponível; }
            set { estoqueDisponível = value; }
        }
        public double getPrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }
        public double Venda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }
        public void comprar(int qtde) 
        {
            estoqueDisponível += qtde;
        }
        public void vender(int qtde) 
        {
            estoqueDisponível -= qtde;
        }
        public void calcularPrecoVenda() 
        {
            Venda = getPrecoCusto * 1.1;
        }

    }
}
