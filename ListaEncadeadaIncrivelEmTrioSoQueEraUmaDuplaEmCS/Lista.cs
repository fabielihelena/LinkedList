using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeadaIncrivelEmTrioSoQueEraUmaDuplaEmCS
{
    class Lista
    {
        public Item E1;
        public Item En
        {
            get { return UltimoItem(); }
        }
       //public Item En;


        public void AdicionarItens(Item e)
        {
            if (E1 == null)
            {
                E1 = e;
            }

            else
            {
                En.sucessor = e;
            }
        }

        public Item UltimoItem()
        {
            Item atual = E1;
            while (atual.sucessor != null)
            {
                atual = atual.sucessor;
            }
            return atual;
        }

        public void MostrarLista()
        {
            Item ordem = E1;
            while(ordem.sucessor != null)
            {
                Console.WriteLine(E1);
                ordem = ordem.sucessor;
            }
        }
    }
}
