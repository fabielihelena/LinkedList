using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEncadeadaIncrivelEmTrioSoQueEraUmaDuplaEmCS
{
    public partial class Form1 : Form
    {
        Lista lista;
        public Form1()
        {
            InitializeComponent();
            lista = new Lista();
            lista.AdicionarItens(new Item(lista.Contador));

        }

        private void AdicionarElementos(object sender, EventArgs e)
        {
            Item item = new Item(lista.Contador + 1);
            lista.AdicionarItens(item);
            Console.WriteLine(lista.Contador);
        }
    }
}
