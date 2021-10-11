using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frnP6 : Form
    {
        public frnP6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                fnrFinal Final = new fnrFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                MessageBox.Show("Resposta errada", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                fnrFinal Final = new fnrFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
            }
        }

        private void frnP6_Load(object sender, EventArgs e)
        {

        }
    }
}
