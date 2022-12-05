using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class produtos : Form
    {
        /*public produtos()
        {
            InitializeComponent();
      } */ 
        
              
        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = null ;
            string produto = null;
            string preco = null;

            codigo = textBox1.Text;
            produto = textBox2.Text;
            preco = textBox3.Text; 
            

            
            /*  
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            */

            //verificar se os dados são validos
            int x;
            double y;
            try 
            {

                ///verificar se o codigo é inteiro 
                if(!int.TryParse(textBox1.Text, out x))
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo Inteiro");
                }else if (Convert.ToInt32(textBox1.Text) < 100)
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo com 3 ou mais digitos");
                }
                //verificar se é uma descricão valida
                if(textBox2.Text.Equals("") ||
                    textBox2.Text.Length < 3 ||
                    textBox2.Text.Length > 50)
                {
                    textBox2.Focus();
                    throw new Exception("Insira uma descrição com 3 digitos e superior a 50");
                }

                if(double.TryParse(textBox3.Text, out y))
                {
                    textBox2.Focus();
                    throw new Exception("Digite um valor numerico");
                }else if (Convert.ToDouble(textBox3) <= 0)
                {
                    textBox2.Focus();
                    throw new Exception("Digite um valor superior a 0");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

                listBox1.Items.Add(codigo + "--" + produto + "--" + preco + "€");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //declar um vetor para armazenar os registros
        private const int maxproduts = 100;
        private readonly prodc[] Produtos;

        //declarar um contador de registo
        private int num_produto;

        public produtos()
        {
            //criar e inicializar produtos
            Produtos = new prodc[maxproduts];

            InitializeComponent();
            //combobox conf 
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hardware");
            comboBox1.Items.Add("Software");
            comboBox1.SelectedIndex = -1;
        }
        private void Limpar()
        {
            
        }

        private void produtos_Load(object sender, EventArgs e)
        {
            Limpar();

        }
        
        private void AdicionaProduto(prodc p)
        {
            if(num_produto < maxproduts)
            {
                  Produtos[num_produto++] = p;
            }

        }
        
    }

}
