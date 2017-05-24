using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Revision_Jonathan
{
    public class Station
    {
        #region attributes
        private string directeur;
        private int numero;
        private string ville;
        private List<Remontee> listeRemontees;
        private List<Departement> listeDepartements;
        #endregion

        #region methods

        private string Directeur
        {
            get { return directeur; }
            set { directeur = value; }
        }

        private int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private List<Remontee> ListeRemontees
        {
            get { return listeRemontees; }
            set { listeRemontees = value; }
        }

        private List<Departement> ListeDepartements
        {
            get { return listeDepartements; }
            set { listeDepartements = value; }
        }

        public void ajouterRemontee(Remontee laRemontee)
        {
            listeRemontees.Add(laRemontee); 
        }
        //PB: la remontee est soit un teleSiege /TeleSki donc comment insérer une remontée ou untélésk dans cette fonction ?

        public int donneDistance(List<Remontee> listeDesRemonteesDeLaStation)
        {
            int laDistance = listeDesRemonteesDeLaStation.Sum(laRemontee => laRemontee.Distance);
            return laDistance;
            //demander si syntaxe correcte plutot que d'utiliser un foreach
        }

        public List<Remontee> donneRemonteeAltitude(double altitudeAComparer)
        {
            List<Remontee> listeDesRemonteesAltitudeElevee = new List<Remontee>();
            foreach (Remontee laRemontee in listeRemontees)
            {
                if (laRemontee.Altitude > altitudeAComparer)
                {
                    
                    listeDesRemonteesAltitudeElevee.Add(laRemontee);
                }
            }
            return listeDesRemonteesAltitudeElevee;
        }

        public List<TeleSki> DonneLesTeleSki()
        {
            List<TeleSki>laListeDesTeleSki = new List<TeleSki>();
            foreach (Remontee laRemontee in this.ListeRemontees)
            {
                if(laRemontee is TeleSki)
                {
                    laListeDesTeleSki.Add((TeleSki)laRemontee);
                }
            }
            return laListeDesTeleSki;
        }

        public List<TeleSiege> DonneLesTeleSiege(List<Remontee> laListeDeRemontees)
        {
            List<TeleSiege> laListeDesTeleSiege = new List<TeleSiege>();
            foreach (Remontee laRemonte in ListeRemontees)
            {
                if(laRemonte is TeleSiege)
                {
                    laListeDesTeleSiege.Add((TeleSiege)laRemonte);
                }
            }
            return laListeDesTeleSiege;
        }


        public void debrayeTeleski(int numero) //V1
        {
            int i = 0;

            Boolean trouveOuPas = false;

            while (!trouveOuPas && i < this.listeRemontees.Count)
            {
                int leNumero = this.listeRemontees[i].Numero == numero);
                {
                    trouveOuPas = true;
                    
                }
            }
        }

        public void debrayeTeleski()
        {
            //on pouvait utiliser IndexOf pour trouver les Teleski puis les débrayer. gérer l'exception , si indexof = -1
        }

        #endregion
    }

    //pour tester 2 listes entre elles ont peut utiliser collection list

    // dans ce projet on est obligés de caster pour pourvoir appeler certaines méthodes

}
