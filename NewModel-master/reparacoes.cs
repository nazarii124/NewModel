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
    public partial class reparacoes : Form
    {
         private const int MaxAvarias = 200;
        private readonly avarias[] avarias;
        private int num_avarias;
        
        public reparacoes()
        {
            avarias = new avarias[MaxAvarias];
            num_avarias = 0;
            InitializeComponent();
        }

        private void limpar()
        {
            txtcodigo.ResetText();
            dt.Value = DateTime.Now;
            txtnome.ResetText();
            txtcontacto.ResetText();
            txtemail.ResetText();
            cbAvaria.SelectedIndex = -1;
            checkBox1.Checked = false;
            txtcodigo.Focus();
        }

        private void reparacoes_Load(object sender, EventArgs e)
        {
            cbAvaria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvaria.Items.Clear();
            cbAvaria.Items.Add("Não Liga");
            cbAvaria.Items.Add("Bloqueia");
            cbAvaria.Items.Add("Ecrã com defeito");
            cbAvaria.Items.Add("Teclado com defeito");
            cbAvaria.Items.Add("Software com erros");
            cbAvaria.Items.Add("Não lê cartão SIM");
            cbAvaria.Items.Add("Não lê catão Memoria");
            cbAvaria.Items.Add("Desliga-se");
            cbAvaria.Items.Add("Não Carrega");
            cbAvaria.SelectedIndex = -1;

            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AllowUserToAddRows= false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.ColumnCount = 6;
            grelha.Columns[0].Name = "Codigo";
            grelha.Columns[1].Name = "Data";
            grelha.Columns[2].Name = "Cliente";
            grelha.Columns[3].Name = "Contacto";
            grelha.Columns[4].Name = "Descrição";
            grelha.Columns[5].Name = "Garantia";
            grelha.Rows.Clear();
            limpar();
        }
        
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void AdicionaAvaria(avarias av)
        {
            if(num_avarias < MaxAvarias)
            {
                avarias[num_avarias++] = av;
            }
        }

        private void tsguardarsair_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\data";
                if (!Directory.Exists(target))
                {
                    DirectoryInfo di = Directory.CreateDirectory(target);

                }
                string caminho = target + "\\avarias.txt";
                Stream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                StreamWriter registo = new StreamWriter(ficheiro);

                for(int i = 0; i < num_avarias; i++)
                {
                    int codigo = avarias[i].getCodigo();
                    DateTime data = avarias[i].GetData();
                    string nome = avarias[i].getnomeCliente();
                    long contacto = avarias[i].getTelefone();
                    string email = avarias[i].getemail();
                    string avaria = avarias[i].getavaria();
                    bool garantia = avarias[i].getgarantia();

                    registo.Write(codigo + ";");
                    registo.Write(data + ";");
                    registo.Write(nome + ";");
                    registo.Write(contacto + ";");
                    registo.Write(email + ";");
                    registo.Write(avaria + ";");
                    registo.Write(garantia + ";");
                    registo.Write(Environment.NewLine);
                }
                registo.Close();
                ficheiro.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnvalidar_Click_1(object sender, EventArgs e)
        {
            int x;
            //double y;
            try
            {

                ///verificar se o codigo é inteiro 
                if (!int.TryParse(txtcodigo.Text, out x))
                {
                    txtcodigo.Focus();
                    throw new Exception("Insira um Codigo Inteiro");
                }
                else if (Convert.ToInt32(txtcodigo.Text) < 1)
                {
                    txtcodigo.Focus();
                    throw new Exception("Insira um Codigo com 3 ou mais digitos");
                }
                //verificar se é uma descricão valida
                if (txtnome.Text.Equals("") ||
                    txtnome.Text.Length < 3 ||
                    txtnome.Text.Length > 50)
                {
                    txtnome.Focus();
                    throw new Exception("Insira um nome com 3 digitos e inferior a 50");
                }
                if (!int.TryParse(txtcontacto.Text, out x))
                {
                    txtcontacto.Focus();
                    throw new Exception("Insira um contacto valido");

                }
                else if (Convert.ToInt32(txtcontacto.Text) < 210000000)
                {
                    txtcontacto.Focus();
                    throw new Exception("Insira um Contacto Valido");
                }
                if (cbAvaria.SelectedIndex == -1)
                {
                    throw new Exception("Escolha uma avaria");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //colocar uma linha no datagridview
            grelha.Rows.Add(txtcodigo.Text.ToString(), txtnome.Text.ToString(), txtcontacto.Text.ToString(), cbAvaria.SelectedItem, checkBox1.Checked ? "Sim" : "Não");

            int codigo = Convert.ToInt32(txtcodigo.Text);
            DateTime data = dt.Value;
            string nome = txtnome.Text;
            long contacto = Convert.ToInt64(txtcontacto.Text);
            string email = txtemail.Text;
            string avaria = cbAvaria.SelectedText;
            bool garantia = checkBox1.Checked;
            AdicionaAvaria(new avarias(codigo, data, nome, contacto, email, avaria, garantia));

            limpar();
        }
    }
}
