namespace BP.Utilkit
{
    public class XOREncryption : IEncryptor
    {
        private readonly byte key = 0xAA;
        public XOREncryption(byte key)
        {
            this.key = key;
        }

        public byte[] Decrypt(byte[] data)
        {
            return PerformXOR(data);
        }

        public byte[] Encrypt(byte[] data)
        {
            return PerformXOR(data);
        }

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
