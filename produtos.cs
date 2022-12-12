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
           
            

            //verificar se os dados são validos
            int x;
            double y;
            try 
            {

                ///verificar se o codigo é inteiro 
                if(!int.TryParse(codigo, out x))
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo Inteiro");
                }else if (Convert.ToInt32(codigo) < 100)
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo com 3 ou mais digitos");
                }
                //verificar se é uma descricão valida
                if(produto.Equals("") ||
                    produto.Length < 3 ||
                    produto.Length > 50)
                {
                    textBox2.Focus();
                    throw new Exception("Insira um produto com 3 digitos e inferior a 50");
                }

                if(!double.TryParse(preco, out y))
                {
                    textBox3.Focus();
                    throw new Exception("Digite um valor numerico");
                }else if (Convert.ToDouble(preco) <= 0)
                {
                    textBox3.Focus();
                    throw new Exception("Digite um valor superior a 0");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            listBox1.Items.Add(codigo + "|" + produto + "|" + preco + "€");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
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

        
        private void AdicionaProduto(prodc p)
        {
            if(num_produto < maxproduts)
            {
                  Produtos[num_produto++] = p;
            }

        }

    

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            string[] campos = new string[5];
            campos = listBox1.SelectedItem.ToString().Split('|');
            //campos[1] = listBox1.SelectedItem.ToString().Split('|');
            //campos[2] = listBox1.SelectedItem.ToString().Split('|');
            //campos[3] = listBox1.SelectedItem.ToString().Split('|');
            textBox1.Text = campos[0].Trim();
            textBox2.Text = campos[1].Trim();
          /* switch (campos[2].Trim())
            {
                case "Hardware": comboBox1.SelectedIndex = 0; break;
                case "Software": comboBox1.SelectedIndex = 1; break;
                default: comboBox1.SelectedIndex = -1; break;

            }*/
            textBox3.Text = campos[2].Trim();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
