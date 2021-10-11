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
    public partial class frnP2 : Form
    {
        public frnP2()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnerrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtncerta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnerrada3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnerrada4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnerrada2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                frnP4 P4 = new frnP4();
                P4.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta errada", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frnP4 P4 = new frnP4();
                P4.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
            }
        }
    }
}
