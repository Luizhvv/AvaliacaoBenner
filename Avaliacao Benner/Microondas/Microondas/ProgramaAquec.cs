using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class ProgramaAquec
    {
        private string Nome;
        private string Instrucoes;
        private char CaracterAquec;
        private string Tempo;
        private int Potencia;
        private string Compatibilidade;

        public ProgramaAquec(string nome, string instrucoes, char caracteraquec, string tempo, int potencia, string compatibilidade)
        {
            this.Nome = nome;
            this.Instrucoes = instrucoes;
            this.CaracterAquec = caracteraquec;
            this.Tempo = tempo;
            this.Potencia = potencia;
            this.Compatibilidade = compatibilidade;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getInstrucoes()
        {
            return this.Instrucoes;
        }

        public void setInstrucoes(string instrucoes)
        {
            this.Instrucoes = instrucoes;
        }

        public char getCaracterAquec()
        {
            return this.CaracterAquec;
        }

        public void setCaracterAquec(char caracteraquec)
        {
            this.CaracterAquec = caracteraquec;
        }

        public string getTempo()
        {
            return this.Tempo;
        }

        public void setTempo(string tempo)
        {
            this.Tempo = tempo;
        }

        public int getPotencia()
        {
            return this.Potencia;
        }

        public void setPotencia(int potencia)
        {
            this.Potencia = potencia;
        }

        public string getCompatibilidade()
        {
            return this.Compatibilidade;
        }

        public void setCompatibilidade(string compatibilidade)
        {
            this.Compatibilidade = compatibilidade;
        }

        public int verifCompatibilidade (string alimento)
        {
            if (alimento.ToUpper().Contains(this.Compatibilidade.ToUpper()))
            {
                return 1;
            }
            else
                return 0;
        }


    }
}
