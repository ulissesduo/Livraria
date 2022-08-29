using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Dvd : Produto
    {
        private string diretor;
        private string duracao;
        private string censura;
        public string Diretor
        {
            get { return diretor; }
            set { diretor = value; }
        }
        public string Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }
        public string Censura
        {
            get { return censura; }
            set { censura = value; }
        }

        public string listarProduto() 
        {
            return "Diretor: " +diretor +
                "Duração: " + duracao +
                "Censura: " + censura;
        }
        public double calcularPrecoVenda(double dolar) 
        {
            Venda = getPrecoCusto * dolar;
            return Venda;
        }
    }
}
