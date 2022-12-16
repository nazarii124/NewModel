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

        private int num_categorias=0;
       
        public categorias()
        { 
            //criar e inicializar o vetor 
            categoria = new cate[MaxCategorias];
            num_categorias = 0;
            InitializeComponent();
        }
        
        private void limpar()
        {
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtZona.Clear();
            txtPrateleira.Clear();
            txtFila.Clear();

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
        private int poslinha = -1;

        private void button1_Click(object sender, EventArgs e)
        {

            int x;
            //double y;
            try
            {

                ///verificar se o codigo é inteiro 
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Codigo Inteiro");
                }
                else if (Convert.ToInt32(txtCodigo.Text) < 100)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Codigo com 3 ou mais digitos");
                }
                //verificar se é uma descricão valida
                if (txtCategoria.Text.Equals("") ||
                    txtCategoria.Text.Length < 3 ||
                    txtCategoria.Text.Length > 50)
                {
                    txtCategoria.Focus();
                    throw new Exception("Insira um produto com 3 digitos e inferior a 50");
                }
                if (txtZona.Text.Equals("") ||
                   !System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "^[a-zA-Z]"))
                {
                    txtZona.Focus();
                    throw new Exception("Insira a zona (letra A a Z)");

                }
                if (!int.TryParse(txtFila.Text, out x))
                {
                    txtFila.Focus();
                    throw new Exception("Insira na fila um valor inteiro");
                }
                else if (Convert.ToInt32(txtFila.Text) < 1 || Convert.ToInt32(txtFila.Text) >100)
                {
                    txtFila.Focus();
                    throw new Exception("Digite um valor para a fila entre 1 e 100");
                }
                if(!int.TryParse(txtPrateleira.Text, out x))
                {
                    txtPrateleira.Focus();
                    throw new Exception("Insira na prateleira um valor inteiro.");
                } else if(Convert.ToInt32(txtPrateleira.Text) < 1 || Convert.ToInt32(txtPrateleira.Text) > 10)
                {
                    txtPrateleira.Focus();
                    throw new Exception("Insira na prateleira um valor entre 1 e 10.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //colocar uma linha no datagridview
            grelha.Rows.RemoveAt(poslinha);
            grelha.Rows.Insert(poslinha,txtCodigo.Text, txtCategoria.Text, txtZona.Text, txtFila.Text, txtPrateleira.Text);
            limpar();

        }
        

        private void grelha_DoubleClick(object sender, EventArgs e)
        {
            poslinha = grelha.CurrentCell.RowIndex;
            if(poslinha != -1)
            {
                txtCodigo.Text = grelha.Rows[poslinha].Cells[0].Value.ToString();
                txtCategoria.Text = grelha.Rows[poslinha].Cells[1].Value.ToString();
                txtZona.Text = grelha.Rows[poslinha].Cells[2].Value.ToString();
                txtFila.Text = grelha.Rows[poslinha].Cells[3].Value.ToString();
                txtPrateleira.Text = grelha.Rows[poslinha].Cells[4].Value.ToString();
                txtCodigo.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(poslinha != -1)
            {
                grelha.Rows.RemoveAt(poslinha);
                poslinha = -1;
                limpar();
            }
            else
            {
                MessageBox.Show("Não existe categoria selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void AdicionarCategoria(cate c)
        {
            if (num_categorias < MaxCategorias)
            {
                categoria[num_categorias++] = c;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            //colocar os dados
            foreach(DataGridViewRow linha in grelha.Rows)
            {
                int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                string xcategoria = linha.Cells[1].Value.ToString();
                string zona = linha.Cells[2].Value.ToString();
                int fila = Convert.ToInt32(linha.Cells[3].Value.ToString());
                int prateleira = Convert.ToInt32(linha.Cells[4].Value.ToString());

                AdicionarCategoria(new cate(codigo, xcategoria, zona, fila, prateleira));


            }
        }
    }
}
