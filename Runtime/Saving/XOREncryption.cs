namespace BP.UniKit
{
    /// <summary>
    /// Simple XOR-based encryptor.
    /// </summary>
    public class XOREncryption : IEncryptor
    {
        private readonly byte key = 0xAA;

        public XOREncryption(byte key)
        {
            this.key = key;
        }

        public byte[] Decrypt(byte[] data) => PerformXOR(data);
        public byte[] Encrypt(byte[] data) => PerformXOR(data);
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
