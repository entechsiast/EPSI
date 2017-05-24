using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forfaitSkiSaison;

namespace Passerelle
{
    [Serializable] // de façon à ce que les donnée puissent être sérializées dans un fichier
    public static class PasserelleForfait
    {


        public static void rempliListeForfaits()
        {
            List<ForfaitSki.ForfaitSki> listeDeForfait = new List<ForfaitSki.ForfaitSki>();
            

            ForfaitSki.ForfaitSki unForfait = new ForfaitSki.ForfaitSki("guittard", "jonathan", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki deuxForfait = new ForfaitSki.ForfaitSki("eniona", "guillaume", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki troisForfait = new ForfaitSki.ForfaitSki("lePACMAN", "Jean-Eude", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki quatreForfait = new ForfaitSki.ForfaitSki("goldorak", "guillaume", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki cinqForfait = new ForfaitSki.ForfaitSki("sage", "jonathan", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki sixForfait = new ForfaitSki.ForfaitSki("richard", "guillaume", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki septForfait = new ForfaitSki.ForfaitSki("camembert", "jonathan", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
            ForfaitSki.ForfaitSki huitForfait = new ForfaitSki.ForfaitSki("coeurDeLion", "guillaume", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));


            listeDeForfait.Add(unForfait);
            listeDeForfait.Add(deuxForfait);
            listeDeForfait.Add(troisForfait);
            listeDeForfait.Add(quatreForfait);
            listeDeForfait.Add(cinqForfait);
            listeDeForfait.Add(sixForfait);
            listeDeForfait.Add(septForfait);
            listeDeForfait.Add(huitForfait);

            

        }

        public static void rempliListeForfaitSkiSaison()
        {
            List<ForfaitSkiSaison> listeForfaitSkiSaisons = new List<ForfaitSkiSaison>();

            ForfaitSkiSaison unForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison deuxForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison troisForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison quatreForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison cinqForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison sixForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison septForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");
            ForfaitSkiSaison huitForfaitSkiSaison = new ForfaitSkiSaison("jojo", "lasticot", new DateTime(2003, 07, 01), "20 rue de la porte sans poignée", "118218", "port-les-chaussons");

            listeForfaitSkiSaisons.Add(unForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(deuxForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(troisForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(quatreForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(cinqForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(sixForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(septForfaitSkiSaison);
            listeForfaitSkiSaisons.Add(huitForfaitSkiSaison);
        }
    }
}
