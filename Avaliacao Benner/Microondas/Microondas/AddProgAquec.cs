using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class AddProgAquec : Form
    {
        string[] prog;

        public AddProgAquec()
        {
            InitializeComponent();
        }

        public void setProg(string[] prog)
        {
            this.prog = prog;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int verifTempo(int minuto, int segundo)
        {
            if ((0 <= minuto && minuto <= 2) && (1 <= segundo && segundo <= 60))
            {
                return 1;
            }
            else
                return 0;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int Minuto = -1, Segundo = -1;

            if (tbTempo.Text.Length == 4)
            {
                if (tbTempo.Text[1].Equals(':'))
                {
                    if (Int32.TryParse(tbTempo.Text[0].ToString(), out Minuto))
                    {
                        string Seg = tbTempo.Text[2].ToString() + tbTempo.Text[3].ToString();

                        if (Int32.TryParse(Seg, out Segundo))
                        {
                            if (verifTempo(Minuto, Segundo) == 1)
                            {
                                prog[0] = tbNome.Text;
                                prog[1] = tbInstrucoes.Text;
                                prog[2] = tbCaracterAquec.Text[0].ToString();
                                prog[3] = tbTempo.Text;
                                prog[4] = nboxPotencia.Value.ToString();
                                prog[5] = tbCompatibilidade.Text;
                                
                                this.Close();
                            }
                            else
                                MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                        }
                        else
                            MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                    }
                    else
                        MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                }
                else
                    MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
            }
            else
            {
                MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
            }
        }
    }
}
