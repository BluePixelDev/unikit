using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BP.Utilkit
{
    /// <summary>
    /// Provides AES-based encryption and decryption using a SHA256-derived key.
    /// Useful for securely storing or transmitting sensitive data.
    /// </summary>
    public class AESEncryption : IEncryptor
    {
        private readonly byte[] key;

        /// <summary>
        /// Initializes a new instance of the <see cref="AESEncryption"/> class using the provided passphrase.
        /// </summary>
        /// <param name="key">A string passphrase that will be hashed using SHA256 to produce the AES key.</param>
        public AESEncryption(string key)
        {
            using SHA256 sha256 = SHA256.Create();
            this.key = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
        }


        /// <summary>
        /// Encrypts the specified byte array using AES.
        /// The IV is prepended to the resulting byte stream.
        /// </summary>
        /// <param name="data">The plain byte array to encrypt.</param>
        /// <returns>The encrypted byte array, with the IV prepended.</returns>
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

        /// <summary>
        /// Decrypts the specified byte array using AES.
        /// Assumes the first 16 bytes of the data are the IV.
        /// </summary>
        /// <param name="data">The encrypted byte array with a prepended IV.</param>
        /// <returns>The decrypted plain byte array.</returns>
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
