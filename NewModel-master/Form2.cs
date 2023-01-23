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
    public partial class consgeral : Form
    {
        public consgeral()
        {
            InitializeComponent();
        }

        private void consgeral_Load(object sender, EventArgs e)
        {
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AllowUserToAddRows = false;
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

            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\data";
                if (!Directory.Exists(target))
                {
                    DirectoryInfo di = Directory.CreateDirectory(target);

                }
                string caminho = target + "\\avarias.txt";
                Stream ficheiro = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                StreamReader registo = new StreamReader(ficheiro);

                string linha = registo.ReadLine();
                string[] dados = linha.Split(';');

                while (linha != null)
                {
                    grelha.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]);
                    linha = registo.ReadLine();
                    if (linha != null)
                    {
                         dados = linha.Split(';');
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
