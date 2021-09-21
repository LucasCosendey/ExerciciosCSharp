using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAleatorioJoaoPodrao
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] carnes = {"Rosbife", "Salami", "Peru", "Presunto", "Pastrami"};
        string[] condimentos = {"mostarda amarela", "mostarda marrom", "mostarda com mel", "maionese", "molho francês"};
        string[] paes = {"centeio", "branco", "trigo", "pão italiano", "árabe"};

        public string GetMenuItem()
        {
            string randomCarne = carnes[Randomizer.Next(carnes.Length)];
            string randomCondimentos = condimentos[Randomizer.Next(condimentos.Length)];
            string randomPaes = paes[Randomizer.Next(paes.Length)];
            return randomCarne + " com " + randomCondimentos + " no " + randomPaes;

        }

    }
}
