using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.txt";
        string encryptedFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_encriptado.txt";
        string decryptedFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_desencriptado.txt";
        
        
        string key = "jdkHHHHHwNjiuqzxxx¿--+";

        // Encriptar el archivo
        EncryptFile(inputFile, encryptedFile, key);

        // Desencriptar el archivo
        /*DecryptFile(encryptedFile, decryptedFile, key);*/
    }

    static void EncryptFile(string inputFile, string outputFile, string key)
    {
        byte[] fileBytes = File.ReadAllBytes(inputFile);
        byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);
        //byte[] keyBytes = key;
        byte[] encryptedBytes = new byte[fileBytes.Length];

        for (int i = 0; i < fileBytes.Length; i++)
        {
            encryptedBytes[i] = (byte)(fileBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        File.WriteAllBytes(outputFile, encryptedBytes);
    }

    static void DecryptFile(string inputFile, string outputFile, byte[] key)
    {
        byte[] encryptedBytes = File.ReadAllBytes(inputFile);
        //byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);
        byte[] keyBytes = key;
        byte[] decryptedBytes = new byte[encryptedBytes.Length];

        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            decryptedBytes[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        File.WriteAllBytes(outputFile, decryptedBytes);
    }
}