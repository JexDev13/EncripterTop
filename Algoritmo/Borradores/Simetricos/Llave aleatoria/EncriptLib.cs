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

        // Generar una clave aleatoria
        byte[] key = new byte[32];
        using (var randomNumberGenerator = new RNGCryptoServiceProvider())
        {
            randomNumberGenerator.GetBytes(key);
        }

        // Encriptar el archivo
        EncryptFile(inputFile, encryptedFile, key);

        // Desencriptar el archivo
        DecryptFile(encryptedFile, decryptedFile, key);
    }

    static void EncryptFile(string inputFile, string outputFile, byte[] key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            // Generar un vector de inicialización aleatorio
            aes.GenerateIV();

            // Escribir el vector de inicialización al archivo cifrado
            using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
            {
                outputFileStream.Write(aes.IV, 0, aes.IV.Length);
            }

            // Cifrar el archivo
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
            using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Append))
            using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                inputFileStream.CopyTo(cryptoStream);
            }
        }
    }

    static void DecryptFile(string inputFile, string outputFile, byte[] key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            // Leer el vector de inicialización del archivo cifrado
            byte[] iv = new byte[aes.IV.Length];
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
            {
                inputFileStream.Read(iv, 0, iv.Length);
            }

            aes.IV = iv;

            // Descifrar el archivo
            using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
            using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
            using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
            {
                cryptoStream.CopyTo(outputFileStream);
            }
        }
    }
}