using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Facture
    {
        string nomClient;
        DateTime date;
        Vehicule vehiculeAcheter; 

        public Facture(Client client, Vehicule vehcule)
        {
            nomClient = client.NomComplet;
            date = DateTime.Now;
            vehiculeAcheter = vehcule;
        }

        public override string ToString()
        {
            string info = $"Information - Facture\n" +
                $"Client : {nomClient} \n" +
                $"Date : {date} \n" +
                $"Vehicule acheter : {vehiculeAcheter}\n";
            return info;
        }

    }
}
