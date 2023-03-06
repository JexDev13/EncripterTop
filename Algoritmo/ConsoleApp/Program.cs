using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        string inputFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.txt";
        string encryptedFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_encriptadoVC.txt";
        string decryptedFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_desencriptadoVC.txt";


        //string keyPath = AppSettings["key"];
        string keyPath = "K:\\llave_privada.key";
        byte[] keyBytes = File.ReadAllBytes(keyPath);

        //Console.WriteLine(File.ReadAllText(keyPath));

        // Encriptar el archivo
        EncryptFile(inputFile, encryptedFile, keyBytes);

        // Desencriptar el archivo
        DecryptFile(encryptedFile, decryptedFile, keyBytes);
    }

    static void EncryptFile(string inputFile, string outputFile, byte[] keyBytes)
    {
        byte[] fileBytes = File.ReadAllBytes(inputFile);
        byte[] encryptedBytes = new byte[fileBytes.Length];

        for (int i = 0; i < fileBytes.Length; i++)
        {
            encryptedBytes[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        File.WriteAllBytes(outputFile, encryptedBytes);
    }

    static void DecryptFile(string inputFile, string outputFile, byte[] keyBytes)
    {
        byte[] encryptedBytes = File.ReadAllBytes(inputFile);
        byte[] decryptedBytes = new byte[encryptedBytes.Length];

        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            decryptedBytes[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        File.WriteAllBytes(outputFile, decryptedBytes);
    }
}