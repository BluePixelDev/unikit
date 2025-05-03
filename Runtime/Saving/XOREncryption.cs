namespace BP.Utilkit
{
    /// <summary>
    /// Provides a simple XOR-based byte-level encryption and decryption.
    /// Primarily intended for lightweight obfuscation, not secure encryption.
    /// </summary>
    public class XOREncryption : IEncryptor
    {
        private readonly byte key = 0xAA;

        /// <summary>
        /// Initializes a new instance of the <see cref="XOREncryption"/> class with the given XOR key.
        /// </summary>
        /// <param name="key">A single byte to use for XOR masking operations.</param>
        public XOREncryption(byte key)
        {
            this.key = key;
        }

        /// <summary>
        /// Encrypts the specified byte array using XOR masking.
        /// </summary>
        /// <param name="data">The plain byte array to encrypt.</param>
        /// <returns>The encrypted (XOR-masked) byte array.</returns>
        public byte[] Decrypt(byte[] data)
        {
            return PerformXOR(data);
        }

        /// <summary>
        /// Encrypts the specified byte array using XOR masking.
        /// </summary>
        /// <param name="data">The plain byte array to encrypt.</param>
        /// <returns>The encrypted (XOR-masked) byte array.</returns>
        public byte[] Encrypt(byte[] data)
        {
            return PerformXOR(data);
        }

        /// <summary>
        /// Performs XOR transformation on the byte array using the specified key.
        /// </summary>
        /// <param name="data">The byte array to transform.</param>
        /// <returns>The transformed byte array.</returns>
        private byte[] PerformXOR(byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key;
            }
            return data;
        }
    }
}
