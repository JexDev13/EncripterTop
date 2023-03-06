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

    
        //Encriptacion asimetrica, no funciono

        // Encriptar el archivo
        string keyPathPub = "H:\\Secreto\\llave_publica.key";
        byte[] keyBytesPub = File.ReadAllBytes(keyPathPub);
        EncryptFile(inputFile, encryptedFile, keyBytesPub);

        // Desencriptar el archivo

        string keyPathPriv = "H:\\Secreto\\llave_privada.key";
        byte[] keyBytesPriv = File.ReadAllBytes(keyPathPriv);
        DecryptFile(encryptedFile, decryptedFile, keyBytesPriv);
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