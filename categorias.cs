using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class categorias : Form
    {
       
        
          //declarar um vetor para aramazenar registro
            private const int MaxCategorias = 100;
            private readonly cate[] categoria;

        private int num_categorias;
       
        public categorias()
        { 
            //criar e inicializar o vetor 
            categoria = new cate[MaxCategorias];
            num_categorias = 0;
            InitializeComponent();
        }
        
        private void limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void categorias_Load(object sender, EventArgs e)
        {
            //configuar o datagridview
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.ColumnCount = 5;
            grelha.Columns[0].Name = "Codigo";
            grelha.Columns[0].Width = 100;
            grelha.Columns[1].Name = "Categoria";
            grelha.Columns[1].Width = 130;
            grelha.Columns[2].Name = "Zona";
            grelha.Columns[2].Width = 80;
            grelha.Columns[3].Name = "Fila";
            grelha.Columns[3].Width = 80;
            grelha.Columns[4].Name = "Prateleira";
            grelha.Columns[4].Width = 100;
            grelha.Rows.Clear();
            limpar();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            //double y;
            try
            {

                ///verificar se o codigo é inteiro 
                if (!int.TryParse(textBox1.Text, out x))
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo Inteiro");
                }
                else if (Convert.ToInt32(textBox1.Text) < 100)
                {
                    textBox1.Focus();
                    throw new Exception("Insira um Codigo com 3 ou mais digitos");
                }
                //verificar se é uma descricão valida
                if (textBox2.Text.Equals("") ||
                    textBox2.Text.Length < 3 ||
                    textBox2.Text.Length > 50)
                {
                    textBox2.Focus();
                    throw new Exception("Insira um produto com 3 digitos e inferior a 50");
                }
                if (textBox3.Text.Equals("") ||
                   !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Z]"))
                {
                    textBox3.Focus();
                    throw new Exception("Insira a zona (letra A a Z)");

                }
                if (!int.TryParse(textBox5.Text, out x))
                {
                    textBox5.Focus();
                    throw new Exception("Insira na fila um valor inteiro");
                }
                else if (Convert.ToInt32(textBox5.Text) < 1 || Convert.ToInt32(textBox5.Text) >100)
                {
                    textBox5.Focus();
                    throw new Exception("Digite um valor para a fila entre 1 e 100");
                }
                if(!int.TryParse(textBox4.Text, out x))
                {
                    textBox4.Focus();
                    throw new Exception("Insira na prateleira um valor inteiro.");
                } else if(Convert.ToInt32(textBox4.Text) < 1 || Convert.ToInt32(textBox4.Text) > 10)
                {
                    textBox4.Focus();
                    throw new Exception("Insira na prateleira um valor entre 1 e 10.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //colocar uma linha no datagridview
            grelha.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            limpar();

        }
        private int poslinha = -1;

        private void grelha_DoubleClick(object sender, EventArgs e)
        {
            poslinha = grelha.CurrentCell.RowIndex;
            if(poslinha != -1)
            {
                textBox1.Text = grelha.Rows[poslinha].Cells[0].Value.ToString();
                textBox2.Text = grelha.Rows[poslinha].Cells[1].Value.ToString();
                textBox3.Text = grelha.Rows[poslinha].Cells[2].Value.ToString();
                textBox4.Text = grelha.Rows[poslinha].Cells[3].Value.ToString();
                textBox5.Text = grelha.Rows[poslinha].Cells[4].Value.ToString();
                textBox1.Focus();


            }
        }
    }
}
