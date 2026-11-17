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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                // campos vazios
                if (textBox_Login_Utilizador.Text.Trim() == "" ||
                    textBox_Login_Password.Text == "")
                {
                    throw new Exception("Preencha todos os campos");
                }

                Globais.utilizadorAtual = -1;

                // procurar a conta
                for (int i = 0; i < Globais.posicaoVazia; i++)
                {
                    if (Globais.listaUtilizadores[i].email.ToLower() ==
                        textBox_Login_Utilizador.Text.Trim().ToLower() &&
                        Globais.listaUtilizadores[i].palavraPasse ==
                        textBox_Login_Password.Text)
                    {
                        Globais.utilizadorAtual = i;
                        break;
                    }
                }

                // verificar se encontrou a conta
                if (Globais.utilizadorAtual == -1)
                {
                    throw new Exception("Email ou palavra-passe incorretos");
                }

                MessageBox.Show("Sessão iniciada com sucesso");
                Form2 janela = new Form2();
                janela.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
