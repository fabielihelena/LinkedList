using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeadaIncrivelEmTrioSoQueEraUmaDuplaEmCS
{
    class Item
    {
        public int elemento;
       
        public Item sucessor;

        public Item (int e)
        {
            elemento = e;
            sucessor = null;
        }
        public Item (int e, Item s)
        {
            elemento = e;
            sucessor = s;
        }
        public int Valor
        {
            get { return elemento; }
            set { elemento = value; }
        }
        public Item Sucessor
        {
            get { return sucessor; }
            set { sucessor = value; }
        }
        
    }
}
