using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Vehicule
    {
        string nom;
        string marque;
        public int prix { get; set; }
        public Moteur moteur { get; set; }
         
        public Vehicule(string nom, string marque, int prix, Moteur moteur)
        {
            this.nom = nom;
            this.marque = marque;
            this.prix = prix;
            this.moteur = moteur;
        }

        public override string ToString()
        {
            string info = $"Nom : {nom} \n" +
                $"marque : {marque} \n" +
                $"prix : {prix} \n" +
                $"{moteur} \n";
            return info;
        }
    }
}
