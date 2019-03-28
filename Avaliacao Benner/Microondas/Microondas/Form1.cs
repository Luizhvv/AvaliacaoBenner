using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Microondas
{
    public partial class Form1 : Form
    {
        ListaProgs Lista = new ListaProgs();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lista = new ListaProgs();
            ProgramaAquec prog = new ProgramaAquec("Degelo", "Lorem ipsum et labore", '$', "0:30", 3, "Congelado");
            Lista.AddPrograma(prog);
            prog = new ProgramaAquec("Miojo", "Lorem ipsum et labore", '+', "1:30", 5, "Miojo");
            Lista.AddPrograma(prog);
            prog = new ProgramaAquec("Fritura", "Lorem ipsum et labore", '@', "0:10", 5, "Coxinha");
            Lista.AddPrograma(prog);
            prog = new ProgramaAquec("Assar", "Lorem ipsum et labore", '#', "2:00", 5, "Batata");
            Lista.AddPrograma(prog);
            prog = new ProgramaAquec("Lanche", "Lorem ipsum et labore", '*', "1:00", 5, "Hamburguer");
            Lista.AddPrograma(prog);

            for (int i = 0; i < Lista.getLista().Count; i++)
            {
                cbProgAquec.Items.Add(Lista.getLista()[i].getNome());
            }
        }

        private void lbPotencia_Click(object sender, EventArgs e)
        {

        }

        private void nboxPotencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private int verifTempo(int minuto, int segundo)
        {
            if((0 <= minuto && minuto <= 2) && (1 <= segundo && segundo <= 60))
            {
                return 1;
            }
            else
                return 0;
        }

        private void Aquecer(int minuto, int segundo, int potencia, char caracterAquec)
        {
            int deltaTsec = minuto * 60 + segundo;
            string linha;
            string Alimento = "";
            int contMin, contSeg;

            try
            {
                StreamReader sr = new StreamReader(tbAlimento.Text);
                linha = sr.ReadLine();
                while (linha != null)
                {
                    Alimento += linha;
                    linha = sr.ReadLine();
                }
                Alimento += linha;
                sr.Close();

                StreamWriter sw = new StreamWriter(tbAlimento.Text);

                sw.WriteLine(Alimento);

                contMin = minuto;
                contSeg = segundo;

                for (int i = 0; i < deltaTsec; i++)
                {
                    Thread.Sleep(1000);
                    contSeg--;
                    if(contSeg == 0 && contMin > 0)
                    {
                        contMin--;
                        contSeg = 60;
                    }
                    lbTempo.Text = contMin + ":" + contSeg;

                    for (int j = 0; j < potencia; j++)
                    {
                        Alimento = Alimento + caracterAquec;
                        sw.WriteLine(caracterAquec);
                    }
                }

                sw.Close();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Alimento = tbAlimento.Text;

                contMin = minuto;
                contSeg = segundo;

                for (int i = 0; i < deltaTsec; i++)
                {
                    Thread.Sleep(1000);
                    contSeg--;
                    if (contSeg == 0 && contMin > 0)
                    {
                        contMin--;
                        contSeg = 60;
                    }
                    lbTimer.Text = contMin + ":" + contSeg;

                    for (int j = 0; j < potencia; j++)
                    {
                        Alimento = Alimento + caracterAquec;
                    }
                }

            }

            tbResultado.Text = Alimento;
            MessageBox.Show("Aquecimento concluído com sucesso: " + Alimento);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int Minuto = -1, Segundo = -1;

            if(tbTempo.Text.Length == 4)
            {
                if(tbTempo.Text[1].Equals(':'))
                {
                    if(Int32.TryParse(tbTempo.Text[0].ToString(), out Minuto))
                    {
                        string Seg = tbTempo.Text[2].ToString() + tbTempo.Text[3].ToString();

                        if(Int32.TryParse(Seg, out Segundo))
                        {
                            if(verifTempo(Minuto, Segundo) == 1)
                            {
                                Aquecer(Minuto, Segundo, Int32.Parse(nboxPotencia.Value.ToString()), '.');
                            }
                            else
                                MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                                //lbErros.Text = "Alerta: O tempo não foi parametrizado corretamente (M:SS) 3";
                        }
                        else
                            MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                            //lbErros.Text = "Alerta: O tempo não foi parametrizado corretamente (M:SS) 2";
                    }
                    else
                        MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                        //lbErros.Text = "Alerta: O tempo não foi parametrizado corretamente (M:SS) 1";
                }
                else
                    MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                    //lbErros.Text = "Alerta: O tempo não foi parametrizado corretamente (M:SS) 0";
            }
            else
            {
                MessageBox.Show("O tempo não foi parametrizado corretamente (M:SS)");
                //lbErros.Text = "Alerta: O tempo não foi parametrizado corretamente (M:SS)";
            }
        }

        private void btnInicioRapido_Click(object sender, EventArgs e)
        {
            Aquecer(0, 30, 8, '.');
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProgAquec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramaAquec result = Lista.BuscaPrograma(cbProgAquec.SelectedItem.ToString());

            tbProgAquecSelec.Text = "Nome: " + result.getNome() + " \n";
            tbProgAquecSelec.Text = tbProgAquecSelec.Text + "Instruções: " + result.getInstrucoes() + " \n";
            tbProgAquecSelec.Text = tbProgAquecSelec.Text + "Tempo: " + result.getTempo() + " \n";
            tbProgAquecSelec.Text = tbProgAquecSelec.Text + "Potência: " + result.getPotencia() + " \n";
            tbProgAquecSelec.Text = tbProgAquecSelec.Text + "Caracter de Aquecimento: " + result.getCaracterAquec() + " \n";
            tbProgAquecSelec.Text = tbProgAquecSelec.Text + "Compatibilidade: " + result.getCompatibilidade() + " \n";
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            List<ProgramaAquec> result = null;

            result = Lista.BuscaProgramas(tbCompatibilidade.Text);

            cbProgAquec.Items.Clear();

            for (int i = 0; i < result.Count; i++)
            {
                cbProgAquec.Items.Add(result[i].getNome());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbProgAquec.Items.Clear();

            for (int i = 0; i < Lista.getLista().Count; i++)
            {
                cbProgAquec.Items.Add(Lista.getLista()[i].getNome());
            }
        }

        private void btnAquecerProg_Click(object sender, EventArgs e)
        {
            ProgramaAquec result = Lista.BuscaPrograma(cbProgAquec.SelectedItem.ToString());
            String Alimento = "", linha;

            try
            {
                StreamReader sr = new StreamReader(tbAlimento.Text);
                linha = sr.ReadLine();
                while (linha != null)
                {
                    Alimento += linha;
                    linha = sr.ReadLine();
                }
                Alimento += linha;
                sr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Alerta: O ");
                Alimento = tbAlimento.Text;
            }

            if (result.verifCompatibilidade(Alimento) == 1)
            {
                Aquecer(Int32.Parse(result.getTempo()[0].ToString()), (result.getTempo()[2] + result.getTempo()[3]), result.getPotencia(), result.getCaracterAquec());
            }
            else
                MessageBox.Show("O alimento não é compatível com o programa.");
                //lbErros.Text = "Alerta: O alimento não é compatível com o programa.";
        }

        private void btnAddProg_Click(object sender, EventArgs e)
        {
            AddProgAquec formAdd = new AddProgAquec();
            string[] prog = new string[6];
            for(int i=0; i<6; i++)
            {
                prog[i] = "Valor";
            }
            formAdd.setProg(prog);
            formAdd.ShowDialog();
            ProgramaAquec addNovo = new ProgramaAquec(prog[0], prog[1], prog[2][0], prog[3], Int32.Parse(prog[4]), prog[5]);
            Lista.AddPrograma(addNovo);
            cbProgAquec.Items.Add(addNovo.getNome());
        }

        
    }
}
