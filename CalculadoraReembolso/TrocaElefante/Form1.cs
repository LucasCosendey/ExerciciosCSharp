using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaElefante
{
    public partial class Form1 : Form
    {
        Elefante lucinda = new Elefante() { name = "Lucinda", EarSize = 33 };
        Elefante loyd = new Elefante() { name = "Loyd", EarSize = 40 };

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loyd.QuemSouEu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.QuemSouEu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elefante trocado;
            trocado = loyd;
            loyd = lucinda;
            lucinda = trocado;
            MessageBox.Show("Elefantes com o corpo trocado.");
        }
    }
}
