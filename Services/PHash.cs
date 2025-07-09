using System;
using System.Security.Cryptography;
using System.Text;

public static class PHash
{
    public static string pwdhash(string strData)
    {
        byte[] message = Encoding.ASCII.GetBytes(strData);

        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashValue = sha256.ComputeHash(message);
            StringBuilder hex = new StringBuilder(hashValue.Length * 2);

            foreach (byte b in hashValue)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }
    }
    public static string pwdhash2(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Convert input string to byte array
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            // Compute hash
            byte[] hashBytes = sha256.ComputeHash(bytes);

            // Convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }
    }

    /*using System.Security.Cryptography;
using System.Text;

public static string GetSha256FromString(string strData)
{
    byte[] message = Encoding.ASCII.GetBytes(strData);

    using (SHA256 sha256 = SHA256.Create())
    {
        byte[] hashValue = sha256.ComputeHash(message);
        StringBuilder hex = new StringBuilder(hashValue.Length * 2);

        foreach (byte b in hashValue)
        {
            hex.AppendFormat("{0:x2}", b);
        }

        return hex.ToString();
    }
} */


    public static string CreateSHA256(string input)
    {
        // Use input string to calculate MD5 hash
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }


    }
}