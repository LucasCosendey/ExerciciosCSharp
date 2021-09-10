using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraReembolso
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;

        double milesTraveled; //Milhas viajadas - transformar em Kilometros
        double reiburseRate = 0.39d; //Taxa de reembolso
        double amountOwed;   //quantia devida
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reiburseRate;
                label4.Text = "R$" + amountOwed;
            }
            else
            {
                MessageBox.Show("A quilometragem inicial precisa ser menor que a final", "Impossível calcular");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milesTraveled = endingMileage -= startingMileage;
            MessageBox.Show(milesTraveled.ToString());
        }
    }
}
