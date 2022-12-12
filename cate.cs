using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdi
{
    public  class cate
    {
        //atributos 
        private int codigo;
        private string categoria;
        private string zona;
        private int fila;
        private int prateleira;

       //construtor

        public cate(int codigo,string categoria,string zona, int fila , int prateleira)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.zona = zona; 
            this.fila = fila;
            this.prateleira = prateleira;
        }
        //seletores(getters)
        public int getCodigo() { return this.codigo; }
        public string getCategoria() { return this.categoria; }
        public string getZona() { return this.zona; }
        public int getFila() { return this.fila; } 
        public int getPrateleira() { return this.prateleira; }

        //modificadores (setters)
        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setZona(string zona) { this.zona = zona; }
        public void setFila(int fila) { this.fila = fila; }
        public void setCategorias(string categoria) { this.categoria = categoria; }
       public void setPrateleira(int prateleira) { this.prateleira = prateleira; }

       

    }
}
