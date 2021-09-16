using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaElefante
{
    class Elefante
    {
        public String name;
        public int EarSize;

        public void QuemSouEu()
        {
            System.Windows.Forms.MessageBox.Show("Minhas orelhas medem " + EarSize, this.name + " diz." );
        }
    }
}
