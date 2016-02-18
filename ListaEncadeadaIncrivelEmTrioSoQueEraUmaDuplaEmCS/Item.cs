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

        public int Elemento (int e)
        {
            e = elemento;
            sucessor = null;
            return e;
        }

      
    }
}
