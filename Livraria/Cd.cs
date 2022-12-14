using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Cd : Produto
    {
        private string artista;
        private string gravadora;
        private string paisOrigem;
        public Cd() 
        {
        
        }
        public Cd(string artista, string gravadora, string paisOrigem, string descricao, string genero, int estoquedisponivel, double precocusto, double precovenda) : base(descricao, genero, estoquedisponivel, precocusto, precovenda)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.paisOrigem = paisOrigem;

        }

        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }
        public string Gravadora
        {
            get { return gravadora; }
            set { gravadora = value; }
        }
        public string PaisOrigem
        {
            get { return paisOrigem; }
            set { paisOrigem = value; }
        }
        public string listarProduto()
        {
            return "Artista: " +artista + 
                "\nGravadora: " + gravadora + 
                "\nPais de Origem: " + paisOrigem;
        }
        public void calcularPrecoVenda() 
        {
            Venda = getPrecoCusto*1.15;
        }

    }
}
