// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

public class Program
{
    //public static void Main()
    //{
    //    var key = new byte[32]; // 256 bits
    //    using (var generator = RandomNumberGenerator.Create())
    //    {
    //        generator.GetBytes(key);
    //    }

    //    var base64Key = Convert.ToBase64String(key);
    //    Console.WriteLine($"Generated Key: {base64Key}");
    //}

    public static void Main()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            byte[] key = new byte[64];
            rng.GetBytes(key);
            string base64Key = Convert.ToBase64String(key);
            Console.WriteLine(base64Key);
        }
    }
}

