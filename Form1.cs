namespace mdi
{
    public partial class form1 : Form
    {
        public static form1 intance;

        public form1()
        {
            InitializeComponent();
            intance = this;
            menuStrip1.Enabled = false;
            isloged = false;
             
        }
        public bool isloged;
        produtos prod;
        reparacoes rep;
       
        public void activar(bool a)
        {
            menuStrip1.Enabled = a;

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prod == null)
            {
                prod = new produtos();
                prod.MdiParent = this;
                prod.FormClosed += Produtos_FormClosed;
                prod.Show();
            }
            else prod.Activate();
            
        }

        private void Produtos_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            prod = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
            if(isloged == true)
            {
                label1.Text = "              login";
                isloged=false;

            }else
            {
                login lg = new login();
                lg.Show();
            }
        }

        public void alterarlabel(string aaa)
        {
            label1.Text = aaa;
        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime a = DateTime.Now;
            toolStripStatusLabel1.Text = a.ToString();
        }

        private void fwefwefwefToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep == null)
            {
                rep = new reparacoes();
                rep.MdiParent = this;
                rep.FormClosed += reparacoes_FormClosed;
                rep.Show();
            }
            else rep.Activate();

        }

        private void reparacoes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            rep = null;
        }

    }
}
