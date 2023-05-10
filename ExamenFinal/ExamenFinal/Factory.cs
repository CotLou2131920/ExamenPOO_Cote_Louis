using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    static class Factory
    {
        static List<string> listNom = new List<string>();
        static List<string> listPrenom = new List<string>();
        static Random rand = new Random();


        static public Client CreerClient()
        {
            AjouterNom();
            AjouterPrenom();
            Client client = new Client(listPrenom[rand.Next(listPrenom.Count)]+" "+ listNom[rand.Next(listNom.Count)],rand.Next(5000, 50001));
            return client;
        }

       
        static public void InitialiseNom()
        {
            try
            {
                Factory.CreerClient();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue lors de la lecture du fichier : " + ex.Message);
            }
        }

        static void AjouterNom()
        {
            string fichierNomFamille = "nom_famille.txt";

            using (StreamReader reader = new StreamReader(fichierNomFamille))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listNom.Add(line);
                }
            }
        }

        static void AjouterPrenom()
        {
            string fichierPrenom = "Prenom.txt";

            using (StreamReader reader = new StreamReader(fichierPrenom))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    listPrenom.Add(line);
                }
            }
        }
    }
}
