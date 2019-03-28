using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class ListaProgs
    {
        private List<ProgramaAquec> lista;

        public ListaProgs()
        {
            this.lista = new List<ProgramaAquec>();
        }

        public void AddPrograma(ProgramaAquec programa)
        {
            lista.Add(programa);
        }

        public List<ProgramaAquec> getLista()
        {
            return this.lista;
        }

        public ProgramaAquec BuscaPrograma(string busca)
        {
            ProgramaAquec result = null;

            for (int i = 0; i < this.lista.Count; i++)
            {
                if (busca.Equals(this.lista[i].getNome()))
                {
                    result = this.lista[i];
                }
            }
            return result;
        }

        public List<ProgramaAquec> BuscaProgramas(string busca)
        {
            List<ProgramaAquec> result = new List<ProgramaAquec>();

            for(int i=0; i<this.lista.Count; i++)
            {
                if(this.lista[i].verifCompatibilidade(busca) == 1)
                {
                    result.Add(this.lista[i]);
                }
            }
            return result;
        }
    }
}
