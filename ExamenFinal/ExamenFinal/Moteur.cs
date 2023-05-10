using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    enum Refroidissement
    {
        Air,
        Liquide
    }
    class Moteur
    {
        string marque;
        int HP;
        Refroidissement type;

        public Moteur()
        {
            marque = "Yamaha";
            HP = 50;
            type= Refroidissement.Air;
        }
        public Moteur(string marque, int hP, Refroidissement type)
        {
            this.marque = marque;
            HP = hP;
            this.type = type;
        }

        public static bool operator >(Moteur a, Moteur b)
        {
            bool resultat = false;
            if (a.HP > b.HP)
                resultat = true;
            return resultat;

        }

        public static bool operator <(Moteur a, Moteur b)
        {
            bool resultat = false;
            if (a.HP < b.HP)
                resultat = true;
            return resultat;
        }

        public override string ToString()
        {
            string info = $"Marque du moteur : {marque} \n" +
                $"HP : {HP} \n" +
                $"Type de refoidissement : {type.Humanize()}";
            return info;
        }
    }
}
