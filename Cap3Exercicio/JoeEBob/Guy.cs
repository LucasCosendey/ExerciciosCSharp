using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeEBob
{
    public class Guy
    {
        public String Name;
        public int Cash;
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Não tenho dinheiro o suficiente para lhe dar R$" + amount, Name + " Disse...");
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("R$" + amount + " não é a quantidade que você tem que me pagar", Name + " Disse...");
                return 0;
            }
        }
    }
}
