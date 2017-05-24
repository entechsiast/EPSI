using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForfaitSki
{
    public  class ForfaitSki
    {
        #region attributes

        //variables static (références du forfait)

        private static int dernierNum; //dernier numéro du forfait

        private static double tarifJour; // toujours à 45

        private int numero; // numero de forfait attribué par dernier num.

        private DateTime dateDebut = new DateTime();

        private DateTime dateFin = new DateTime();

        //clients
        private string nom;

        private string prenom;

        private DateTime dateNaiss = new DateTime();

        private string photo;

        #endregion

        #region get/set

        public int DernierNum { get; set; }


        public static double TarifJour
        {
            get { return tarifJour; }
            set { tarifJour = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }


        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }


        public void setNom(string nomDuClient)
        {
            this.nom = nomDuClient.ToUpper();
        }

        public string getNom()
        {
            return this.nom;
        }

        public string Prenom
        {
            get { return prenom; }

        }

        public void setPrenom(string lePrenomDuClient)
        {
            this.prenom = lePrenomDuClient.First().ToString().ToUpper() + lePrenomDuClient.Substring(1);
            // récupère la chaine entrée pour le prénom, passe la première lettre en majuscule et concatène le reste de la string à partir de la 1ème position (après la lettre majuscule, car elle occupe la position 1)
        }

        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }



        #endregion

        #region constructors

        //constructor

        /// <summary>
        /// constructeur de forfait ski sans photo
        /// </summary>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="dateDeDebutDuForfait"></param>
        /// <param name="dateDeFinDuForfait"></param>
        /// <param name="dateNaissClient"></param>
        public ForfaitSki(string nomClient, string prenomClient, DateTime dateDeDebutDuForfait,
                DateTime dateDeFinDuForfait, DateTime dateNaissClient)
        // mieux d'utiliser directement la méthode set dans le construteur pour modifier le prenom et le nom.
        {
            // la modification en ToUpper du nom/prenom doit se faire dans les get/set

            this.setNom(nomClient); // en majuscule
            this.setPrenom(prenomClient);
            this.dateDebut = dateDeDebutDuForfait;
            this.dateFin = dateDeFinDuForfait;
            this.dateNaiss = dateNaissClient;
            augmenteDernierNum();  // incréemente de 1a variable de classe statique dernierNum à la création de l'objet Forfait
            this.numero = dernierNum; // affecte la valeur de dernierNum à numero.

            // manque appel méthode calcul numero


            // serialization


        }

        /// <summary>
        /// constructeur de Forofait ski avec photo
        /// </summary>
        /// <param name="nomClient"></param>
        /// <param name="prenomClient"></param>
        /// <param name="dateDeDebutDuForfait"></param>
        /// <param name="dateDeFinDuForfait"></param>
        /// <param name="dateNaissClient"></param>
        /// <param name="laPhoto"></param>
        public ForfaitSki(string nomClient, string prenomClient, DateTime dateDeDebutDuForfait,
            DateTime dateDeFinDuForfait, DateTime dateNaissClient, string laPhoto)
            : this(nomClient, prenomClient, dateDeDebutDuForfait, dateDeFinDuForfait, dateNaissClient)
        {
            this.photo = laPhoto;
        }

        #endregion

        #region methods
        /// <summary>
        /// incrémente de 1 la valeur du dernier numéro entré lors de la creation du précédent forfait
        /// </summary>
        public void augmenteDernierNum()
        {
            dernierNum++;
            //Interlocked.Increment(ref dernierNum); // compte le nombre de fois qu'à été instancié la classe forfait ski
        }

        /// <summary>
        /// calcule le nombre de jour entre 2 dates et retourne en int le nombre de jours
        /// </summary>
        /// <param name="dateDebutForfait"></param>
        /// <param name="dateFinForfait"></param>
        /// <returns></returns>
        public int donnNbjours()
        {
            TimeSpan nbreJoursSpan;
            int nbreJour;

            nbreJoursSpan = this.dateFin.Subtract(this.dateDebut);
            nbreJour = nbreJoursSpan.Days;

            return nbreJour;
        }

        /// <summary>
        /// donne l'age actuel du client en fonction de la date de naissance de ce dernier et de la date de souscription du forfait.
        /// </summary>
        /// <returns></returns>
        public int donneAge() // en public pour les besoins du test , repasser en private pour la poursuite du dev
        {
            int age;

            age = this.dateDebut.Year - this.dateNaiss.Year;
            
            return age;
        }
        /// <summary>
        /// Calcul le montant journalier à payer par le client sur la durée du forfait choisi et renvoi le montant en double
        /// </summary>
        /// <returns></returns>
        public double donneTarifUnJour()
        {
            double tarifUnJour;

            const double forfaitJourneeNormale = 45;

            const double reductionMoinsDouzeAns = (forfaitJourneeNormale * 20) / 100;

            const double reductionPlusDeSoixanteAns = (forfaitJourneeNormale * 15) / 100;

            int age = this.donneAge();

            if (age <= 12)
            {
                tarifUnJour = Math.Ceiling(forfaitJourneeNormale - reductionMoinsDouzeAns);

                if (age >= 60)
                {
                    tarifUnJour = Math.Ceiling(forfaitJourneeNormale - reductionPlusDeSoixanteAns);
                }

            }
            else tarifUnJour = Math.Ceiling(forfaitJourneeNormale);

            //ajouter l'arrondi de la valeur de

            return tarifUnJour;
        }

          public int calculTarif() //erreur
        {
            int tarifAPayer = Convert.ToInt32(this.donneTarifUnJour() * this.donnNbjours());

            return tarifAPayer;
        }

         public string  ToString() //erreur
        {
            string laChaine;

            laChaine = "";
            laChaine += "le nom est : " + this.nom;
            laChaine += "le prenom est : " + this.nom;
            laChaine += "le age est : " + this.nom;
            laChaine += "la date de Naissance est : " + this.nom;
            laChaine += "la date de debut du forfait est : " + this.nom;
            laChaine += "la date de fin du forfait est : " + this.nom;
            laChaine += "le tarif jour est de : " + Convert.ToString(this.calculTarif());
            laChaine += "le montant total du tarif est de: " + this.nom;

            return laChaine;
        }

        #endregion
    }
}
