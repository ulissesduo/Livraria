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

        public Produto() 
        {
        
        }
        public Produto(string descricao, string genero, int estoquedisponivel, double precocusto, double precovenda) 
        {
            this.descricao = descricao;
            this.genero = genero;
            this.estoqueDisponível = estoquedisponivel;
            this.precoCusto = precocusto;
            this.precoVenda = precovenda;
        }
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
        public virtual void comprar(int qtde) 
        {
            estoqueDisponível += qtde;
        }
        public virtual void vender(int qtde) 
        {
            estoqueDisponível -= qtde;
        }
        public virtual void calcularPrecoVenda() 
        {
            Venda = getPrecoCusto * 1.1;
        }

    }
}
