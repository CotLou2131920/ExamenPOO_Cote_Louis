using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Concessionaire
    {
        string nom;
        public List<Vehicule> vehicules { get; set; }
        public List<Facture> factures { get; set; }
        public double Argent { get; set; }


        public Concessionaire()
        {
            nom = "Chez Vincent";
            vehicules = new List<Vehicule>();
            factures = new List<Facture>();
            Argent = 0;
            RemplirInventaire();
        }

        public void AjouterVehicule(Vehicule vehicule) { vehicules.Add(vehicule); }
        
        public void VendreVehicule(Vehicule vehicule) { vehicules.Remove(vehicule); }

        public string GetInfoInventaire()
        {
            string info = "";
            foreach(Vehicule v in vehicules) 
                info += v.ToString();
            return info;
        }

        public void RemplirInventaire()
        {
            // MOTOMARINE
            vehicules.Add(new MotoMarine("Spark", "BRP", 12000, new Moteur()));
            vehicules.Add(new MotoMarine("Spark GTI", "BRP", 14000, new Moteur()));
            vehicules.Add(new MotoMarine("Mini GTI", "BRP", 9000, new Moteur()));


            vehicules.Add(new MotoMarine("GP1800R", "Yahama", 11000, new Moteur()));
            vehicules.Add(new MotoMarine("GTX", "BRP", 15000, new Moteur("Rotax", 230, Refroidissement.Air)));
            vehicules.Add(new MotoMarine("RTX", "Yahama", 22000, new Moteur("Suprax", 320, Refroidissement.Liquide)));



            // VTT
            vehicules.Add(new VTT("XP 100", "Polaris", 32000, new Moteur()));
            vehicules.Add(new VTT("XP 50", "Polaris", 20000, new Moteur("Evo", 500, Refroidissement.Air)));

            vehicules.Add(new VTT("Ride Command", "Polaris", 15000, new Moteur("Evo", 570, Refroidissement.Liquide)));

            vehicules.Add(new VTT("Foreman 500", "Honda", 10000, new Moteur()));
            vehicules.Add(new VTT("Foreman 750", "Honda", 15000, new Moteur("Master", 300 , Refroidissement.Air)));



        }
        public override string ToString()
        {
            string info = $"Non : {nom} || Montant Final : {Argent}";
            return info;
        }
    }
}
