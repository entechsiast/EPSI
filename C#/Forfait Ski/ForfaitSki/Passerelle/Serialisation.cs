using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Passerelle
{
    public class Serialisation
    {
        public static ArrayList DeSerialise(String nomFichier)
        {
            ArrayList listeDeserial = new ArrayList();

            BinaryFormatter monBF = new BinaryFormatter();
            FileStream monFSLEcture;

            monFSLEcture = new FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Read);

            try
            {
                listeDeserial = (ArrayList)monBF.Deserialize(monFSLEcture);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            monFSLEcture.Close();
            return listeDeserial;
        }

        public static void Serialise(ArrayList listeSerial, String nomFichier)
        {
            BinaryFormatter monBF = new BinaryFormatter();
            FileStream monFSEcriture;

            monFSEcriture = new FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Write);

            try
            {
                monBF.Serialize(monFSEcriture, 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            monFSEcriture.Close();
        }
    }
}
