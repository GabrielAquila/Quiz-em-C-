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
    public partial class frnP4 : Form
    {
        public frnP4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                frnP5 P5 = new frnP5();
                P5.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                MessageBox.Show("Resposta errada", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frnP5 P5 = new frnP5();
                P5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
            }
        }
    }
}
