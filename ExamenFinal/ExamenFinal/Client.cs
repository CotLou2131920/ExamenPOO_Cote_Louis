using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Client
    {
        public string NomComplet { get; set; }
        public int montant { get; set; }
        Random rand = new Random();

        public Client(string nomComplet, int montant)
        {
            this.NomComplet = nomComplet;
            this.montant = montant;
        }

        public override string ToString()
        {
            string info = $"Client : {NomComplet} " +
                $"Montant d'argent : {montant} \n";
            return info;
        }
    }
}
