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
    public partial class frnP1 : Form
    {
        public frnP1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta","Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos+= 1;
                frnP2 P2 = new frnP2();
                P2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                MessageBox.Show("Resposta errada", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frnP2 P2 = new frnP2();
                P2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
            }
        }



        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frnP1_Load(object sender, EventArgs e)
        {

        }
    }
}
