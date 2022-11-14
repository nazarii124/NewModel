namespace mdi
{
    public partial class form1 : Form
    {
        public static form1 intance;

        public form1()
        {
            InitializeComponent();
            intance = this;
           
        }
        produtos produtos;
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (produtos == null)
            {
                produtos = new produtos();
                produtos.MdiParent = this;
                produtos.FormClosed += Produtos_FormClosed;
                produtos.Show();
            }
            else produtos.Activate();
        }

        private void Produtos_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            produtos = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            login lg = new login();
            lg.Show();
        }

        public void alterarlabel(string aaa)
        {
            label1.Text = aaa;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime a = DateTime.Now;
            toolStripStatusLabel1.Text = a.ToString();
        }
    }
}