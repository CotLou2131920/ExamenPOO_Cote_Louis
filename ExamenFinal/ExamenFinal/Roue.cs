using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Roue
    {
        string marque;
        int taille;

        public Roue(string marque, int taille)
        {
            this.marque = marque;
            this.taille = taille;
        }

        public override string ToString()
        {
            string info = $"Marque de roue : {marque} \n" +
                $"Taille : {taille} \n";
            return info;
        }
    }
}
