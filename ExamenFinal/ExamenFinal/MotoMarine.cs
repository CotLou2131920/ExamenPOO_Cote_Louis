using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ExamenFinal
{
    enum Type
    {
        jetSki,
        SeaDoo
    }
    class MotoMarine : Vehicule
    {
        Type type;


        public MotoMarine(string nom, string marque, int prix, Moteur moteur) : base(nom, marque, prix, moteur)
        {
            type = Type.SeaDoo;

        }

        public MotoMarine(string nom, string marque, int prix, Moteur moteur, Type type) : base(nom, marque, prix, moteur)
        {
            this.type = type;

        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"Type de Vehicule : MotoMarine \n" +
                $"Type : {type.Humanize()} \n";
            return info;
        }
    }
}
