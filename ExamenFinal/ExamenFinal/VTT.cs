using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class VTT : Vehicule
    {
        Roue roue;



        public VTT(string nom, string marque, int prix, Moteur moteur, Roue roue) : base (nom,marque,prix,moteur)
        {
            this.roue = roue;
        }

        public VTT(string nom, string marque, int prix, Moteur moteur) : base(nom, marque, prix, moteur)
        {
            this.roue = new Roue("Michelin", 16);
        }


        public override string ToString()
        {
            string info = base.ToString();
            info += $"Type de Vehicule : VTT \n" +
                $"{roue} \n";
            return info;
        }
    }
}
