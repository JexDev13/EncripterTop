using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FormularioED
{
    internal class Algotritmo
    {
        public static String encriptador(string inputFile, string keyPath /*byte[] keyBytes*/)
        {
            byte[] fileBytes = Encoding.ASCII.GetBytes(inputFile);
            byte[] en_decryptedBytes = new byte[fileBytes.Length];
            byte[] keyBytes = null;
            try
            {
                keyBytes = File.ReadAllBytes(keyPath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ingrese los elementos necesarios para realizar esta accion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if(keyBytes != null)
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    en_decryptedBytes[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }
            }
            return Encoding.ASCII.GetString(en_decryptedBytes);
        }
    }
}
