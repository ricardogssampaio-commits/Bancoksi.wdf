using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bancoksi.wdf
{
    public partial class Form_registrar : Form
    {
        public Form_registrar()
        {
            InitializeComponent();
        }

        private void button_Criar_Utilizador_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACOES

                // validacao campos vazios
                if (textBox_Nome_do_Utilizador.Text.Trim() == "" ||
                    textBox_Escolher_Password.Text.Trim() == "")
                {
                    throw new ValidacaoCamposVaziosException(
                        "Preencha todos os campos");
                }

                // Validacao email
                // 1º validacao - Se tem @ e .
                if (!textBox_Nome_do_Utilizador.Text.Contains("@") ||
                    !textBox_Nome_do_Utilizador.Text.Contains("."))
                {
                    throw new ValidacaoDadosException(
                        "O email tem de conter um: @ e um: .");
                }

                // 2º validacao - email ja esta a ser utilizado?
                for (int i = 0; i < Globais.posicaoVazia; i++)
                {
                    if (Globais.listaUtilizadores[i].email.ToLower() ==
                        textBox_Nome_do_Utilizador.Text.Trim().ToLower())
                    {
                        throw new ValidacaoDadosException(
                            "Este email ja esta a ser utilizado");
                    }
                }

                // Validacao da palavra-passe
                if (textBox_Escolher_Password.Text.Length < 6)
                {
                    throw new Exception(
                        "A palavra-passe deve ter pelo menos 6 caracteres");
                }

                // Validacao data nascimento
                if (dateTimePicker1.Value.Date >= DateTime.Today)
                {
                    throw new Exception(
                        "A data de nascimento deve ser anterior a hoje");
                }

                // Verificar se o vetor esta cheio
                if (Globais.posicaoVazia >= Globais.listaUtilizadores.Length)
                {
                    throw new Exception("O limite de utilizadores foi atingido");
                }

                // Passou em todas as validacoes!
                // Guardar Utilizador
                Globais.Utilizador novoUtilizador;

                novoUtilizador.email =
                    textBox_Nome_do_Utilizador.Text.Trim();

                novoUtilizador.palavraPasse =
                    textBox_Escolher_Password.Text;

                novoUtilizador.dataNascimento =
                    dateTimePicker1.Value.Date;

                Globais.listaUtilizadores[Globais.posicaoVazia] = novoUtilizador;
                Globais.posicaoVazia++;

                MessageBox.Show("Utilizador registado com sucesso");
            }
            catch (ValidacaoCamposVaziosException ex)
            {
                MessageBox.Show(ex.Message, "Validacao campos vazios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ValidacaoDadosException ex)
            {
                MessageBox.Show(ex.Message, "Validacao Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}