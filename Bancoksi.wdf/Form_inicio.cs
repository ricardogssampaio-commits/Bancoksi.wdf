namespace Bancoksi.wdf
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            using (Form_Login janela = new Form_Login())
            {
                janela.ShowDialog(this);
                this.Hide();
            }
        }

        private void linkLabel_registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form_registrar janela = new Form_registrar())
            {
                janela.ShowDialog(this);
                
            }
        }

        private void button_Sair1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }
    }
    }

