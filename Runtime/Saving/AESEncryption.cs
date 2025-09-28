using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BP.UniKit
{
    /// <summary>
    /// AES Encryptor that uses SHA256 keys.
    /// </summary>
    public class AESEncryption : IEncryptor
    {
        private readonly byte[] key;

        public AESEncryption(string key)
        {
            using SHA256 sha256 = SHA256.Create();
            this.key = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
        }

        public byte[] Decrypt(byte[] data)
        {

            using Aes aes = Aes.Create();
            aes.Key = key;

            byte[] iv = new byte[16];
            Array.Copy(data, 0, iv, 0, iv.Length);
            aes.IV = iv;

            using MemoryStream ms = new(data, iv.Length, data.Length - iv.Length);
            using CryptoStream cs = new(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using MemoryStream resultStream = new();
            cs.CopyTo(resultStream);

            return resultStream.ToArray();
        }

        public byte[] Encrypt(byte[] data)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;

            using MemoryStream ms = new();
            ms.Write(aes.IV, 0, aes.IV.Length);

            using CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }
    }
}
