using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdi
{
    internal class prodc
    {
        //atributos
        private int codigo;
        private string nomeproduto;
        private int categoria;
        private double preco; 

        public prodc()
        {
            this.codigo = 0;
            this.nomeproduto = "";
            this.categoria = -1;
            this.preco = 0;
        }

        public prodc(int codigo, string nomeproduto, int categoria, double preco)
        {
            this.codigo = codigo;
            this.nomeproduto = nomeproduto;
            this.categoria = categoria;
            this.preco = preco;
        }

        //Seletores 
        public int getcodigo()   { return codigo; }
        public string getnomeproduto() { return nomeproduto; }

        public int getcategoria() { return categoria;  }
        public double getPreco() { return preco; }

        public void setcodigo (int codigo) { this.codigo = codigo; }
        public void setcategotia(int categoria) { this.categoria = categoria; }
        public void setnomeproduto(string nomeproduto) { this.nomeproduto = nomeproduto; }
        public void setpreco(double preco) { this.preco = preco; }
    }

}
