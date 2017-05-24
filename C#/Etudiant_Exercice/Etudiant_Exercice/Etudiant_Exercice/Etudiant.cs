using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant_Exercice
{
    public class Etudiant
    {
        #region attibutes

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private double noteDuBac;

        public double NoteDuBac
        {
            get { return noteDuBac; }
            set { noteDuBac = value; }
        }

        #endregion

        #region methods

        public Etudiant(string nom, double noteDuBac)
        {
            this.nom = nom;
            this.noteDuBac = noteDuBac;
        }
        public string donneMention()
        {
            string mention = "";
            string[] lesMentions = new string[] { "très bien", "bien", "assez bien","passable", "oral", "ajourné" };

            if (this.noteDuBac < 8)
            {
                mention = lesMentions[5];

            }

            else if (this.noteDuBac < 10)
            {
                mention = lesMentions[4];
            }

            else if (this.noteDuBac < 12)
            {
                mention = lesMentions[3];
            }

            else if (this.noteDuBac < 14)
            {
                mention = lesMentions[2];
            }
            else if (this.noteDuBac < 16)
            {
                mention = lesMentions[1];
            }
            else 
            {
                mention = lesMentions[0];
            }
            return mention;
        }

       
        #endregion
    }

     
}

/* Terminer les test à 100 % faire dans un fichier XML

            <lesValeurs>
                <unTest>
                    <note> 5 </note>
                    <mentionAttendue> ajourné </mention>

             </lesValeurs> */
