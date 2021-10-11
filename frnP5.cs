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
    public partial class frnP5 : Form
    {
        public frnP5()
        {
            InitializeComponent();
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                frnP6 P6 = new frnP6();
                P6.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                MessageBox.Show("Resposta errada", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frnP6 P6 = new frnP6();
                P6.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
            }
        }
    }
}
