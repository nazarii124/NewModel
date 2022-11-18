using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text.Equals("admin") && textBox1.Text.Equals("admin"))
            {
                form1.intance.alterarlabel("Fechar Sessão");
                MessageBox.Show("Login com sucesso.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                form1.intance.isloged = true;
                form1.intance.activar(true);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Login Errado.", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            textBox2.PasswordChar = 'x';
        }
        
        

    }
}
