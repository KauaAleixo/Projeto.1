using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "Texto para hash";
        string hash = ComputeSha256Hash(input);
        Console.WriteLine($"Hash SHA256: {hash}");
    }

    static string ComputeSha256Hash(string rawData)
    {
        // Cria uma instância do SHA256
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // Converte a string de entrada em bytes e calcula o hash
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Converte o hash (array de bytes) em uma string hexadecimal
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}