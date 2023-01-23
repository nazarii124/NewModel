using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdi
{
    internal class avarias
    {
        private int codigo;         //maior que 0
        private DateTime data;      //data por extenso
        private string nomeCliente; //limitar aos 50 caracteres
        private long telefone;      //9 digitos
        private string email;       //não vazio
        private string avaria;      //item combo box
        private bool garantia;      //check box 0 ou 1 

        //contrutor vazio
        public avarias()
        {
            this.codigo = 0;
            this.data = DateTime.MinValue;
            this.nomeCliente = "";
            this.telefone = 0;
            this.email = "";
            this.avaria = "";
            this.garantia = false;
        }

        public avarias(int codigo, DateTime data, string nomeCliente,long telefone, string email,
            string avaria,bool garantia )
        {
           this.codigo=codigo;
           this.data=data;
           this.nomeCliente = nomeCliente;
           this.telefone = telefone;
           this.email = email;
           this.avaria = avaria;
           this.garantia = garantia;
        }

        //seletores

        public int getCodigo() { return codigo; }
        public DateTime GetData() { return data; }
        public string getnomeCliente() {return nomeCliente; }
        public long getTelefone() { return telefone; }
        public string getemail() { return email; }
        public string getavaria() { return avaria; }
        public bool getgarantia() { return garantia; }

        //modificardores 

        public void setCodigo (int codigo) { this.codigo = codigo; }
        public void setData (DateTime data) { this.data = data; }
        public void setnomeCliente(string nomeCliente) { this.nomeCliente = nomeCliente; }
        public void setTelefone(long telefone) { this.telefone = telefone; }
        public void setEmail(string email) { this.email = email; }
        public void setavaria(string avaria) { this.avaria = avaria; }
        public void setgarantia(bool garantia) { this.garantia = garantia; }







    }





}
