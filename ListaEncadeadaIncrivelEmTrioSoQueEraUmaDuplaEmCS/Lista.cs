using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeadaIncrivelEmTrioSoQueEraUmaDuplaEmCS
{
    class Lista
    {
        private Item E1;
        public Item En
        {
            get { return UltimoItem(); }
        }
       //public Item En;

        public Lista()
        {
            
        }
        public Lista(Item e)
        {
            
            AdicionarItens(e);
        }

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

        public int Contador
        {
            get
            {
                int contador = 0;
                Item atual = E1;
                while (atual.sucessor != null)
                {
                    E1 = E1.sucessor;
                    contador++;
                }
                return contador;
            }
        }
    }
}
