namespace BP.Utilkit
{
    /// <summary>
    /// Defines methods for encrypting and decrypting data.
    /// </summary>
    public interface IEncryptor
    {
        /// <summary>
        /// Encrypts the specified data using an encryption algorithm.
        /// </summary>
        /// <param name="data">The plaintext data to encrypt.</param>
        /// <returns>The encrypted data as a byte array.</returns>
        byte[] Encrypt(byte[] data);

        /// <summary>
        /// Decrypts the specified encrypted data back into its original plaintext form.
        /// </summary>
        /// <param name="data">The encrypted data to decrypt.</param>
        /// <returns>The decrypted data as a byte array.</returns>
        byte[] Decrypt(byte[] data);
    }
}
