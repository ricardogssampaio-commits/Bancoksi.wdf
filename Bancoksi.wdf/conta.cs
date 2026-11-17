using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancoksi.wdf
{
    public partial class conta : Form
    {
        public conta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 janela = new Form2();
            janela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loja janela = new Loja();
            janela.Show();
            this.Hide();
        }
    }
}
