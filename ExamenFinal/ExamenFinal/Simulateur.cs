using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Simulateur
    {
        Concessionaire monConcessionaire;
        Random rand = new Random();


        public void Simuler()
        {
            monConcessionaire = new Concessionaire();
            List<Client> cliens = GenererListClients();
            SimulerTransaction(cliens);
            if (monConcessionaire.factures.Count > 0)
                Console.WriteLine("********** INFORMATION FACTURE **********");
            foreach (Facture fac in monConcessionaire.factures)
                Console.WriteLine(fac);
            Console.WriteLine("INFORMATION SUR LE CONCESSIONNAIRE");
            Console.WriteLine(monConcessionaire);
        }

        public void SimulerTransaction(List<Client> clients)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                Vehicule choix1;
                Vehicule choix2;
                Vehicule choixFinal;
                try
                {
                    do
                    {
                        choix1 = monConcessionaire.vehicules[rand.Next(monConcessionaire.vehicules.Count)];
                        if (choix1 is null)
                            throw new Exception("Désoler L'inventaire du Concessionaire est vide \n");
                        do
                            choix2 = monConcessionaire.vehicules[rand.Next(monConcessionaire.vehicules.Count)];
                        while (choix1 == choix2);

                    } while (choix1 is MotoMarine && choix2 is VTT || choix1 is VTT && choix2 is MotoMarine);
                    if (choix1.moteur > choix2.moteur)
                        choixFinal = choix1;
                    else 
                        choixFinal = choix2;
                    if (clients[i].montant < choixFinal.prix)
                        throw new Exception($"Désoler le {clients[i]} n'a pas assez d'argent pour ce vehicule \n");
                    else
                    {
                        Facture fac = new Facture(clients[i], choixFinal);
                        monConcessionaire.factures.Add(fac);
                        monConcessionaire.VendreVehicule(choixFinal);
                        monConcessionaire.Argent += choixFinal.prix;
                        clients[i].montant -= choixFinal.prix;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<Client> GenererListClients() 
        {
            List<Client> cli = new List<Client>();
            for (int i = 0; i < rand.Next(2, 6); i++)
            {
                cli.Add(Factory.CreerClient());
            }
            return cli;
        }
    }
}
