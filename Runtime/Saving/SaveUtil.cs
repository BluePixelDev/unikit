using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace BP.Utilkit
{
    /// <summary>
    /// Utility class for Soulbound.Saving and loading JSON data, with optional encryption support.
    /// </summary>
    public class SaveUtil : MonoBehaviour
    {
        /// <summary>
        /// Creates one or more directories if they do not already exist.
        /// </summary>
        /// <param name="paths">One or more directory paths to create.</param>
        public static void CreateDir(params string[] paths)
        {
            foreach (string path in paths)
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    Debug.LogError($"Error creating directory {path}: {e.Message}");
                }
            }
        }

        /// <summary>
        /// Serializes the provided data to JSON, encrypts it using the specified encryption method,
        /// and writes the encrypted bytes to a file.
        /// </summary>
        /// <param name="path">The file path where the data will be saved.</param>
        /// <param name="data">The data object to serialize.</param>
        /// <param name="encryption">The encryption method to apply.</param>
        public static void SaveJson(string path, object data, IEncryptor encryption)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data);
                byte[] dataBytes = Encoding.UTF8.GetBytes(jsonData);
                byte[] encryptedData = encryption.Encrypt(dataBytes);
                File.WriteAllBytes(path, encryptedData);
            }
            catch (Exception e)
            {
                Debug.LogError($"Error Soulbound.Saving encrypted JSON data to {path}: {e.Message}");
            }
        }

        /// <summary>
        /// Serializes the provided data to a formatted JSON string and writes it to a file.
        /// </summary>
        /// <param name="path">The file path where the data will be saved.</param>
        /// <param name="data">The data object to serialize.</param>
        public static void SaveJson(string path, object data)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(path, jsonData);
            }
            catch (Exception e)
            {
                Debug.LogError($"Error Soulbound.Saving JSON data to {path}: {e.Message}");
            }
        }

        /// <summary>
        /// Loads encrypted JSON data from a file, decrypts it using the specified encryption method,
        /// and deserializes it into an object of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type into which the JSON data is deserialized.</typeparam>
        /// <param name="path">The file path to load data from.</param>
        /// <param name="encryption">The encryption method to use for decryption.</param>
        /// <returns>
        /// An object of type <typeparamref name="T"/> deserialized from the decrypted JSON,
        /// or <c>null</c> if the file is not found or an error occurs.
        /// </returns>
        public static T LoadJson<T>(string path, IEncryptor encryption) where T : class
        {
            try
            {
                if (File.Exists(path))
                {
                    byte[] encryptedData = File.ReadAllBytes(path);
                    byte[] decryptedBytes = encryption.Decrypt(encryptedData);
                    string decryptedJson = Encoding.UTF8.GetString(decryptedBytes);
                    return JsonConvert.DeserializeObject<T>(decryptedJson);
                }
                else
                {
                    Debug.LogWarning($"File {path} not found.");
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Error loading encrypted JSON data from {path}: {e.Message}");
                return null;
            }
        }

        /// <summary>
        /// Loads JSON data from a file and deserializes it into an object of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type into which the JSON data is deserialized.</typeparam>
        /// <param name="path">The file path to load data from.</param>
        /// <returns>
        /// An object of type <typeparamref name="T"/> deserialized from the JSON,
        /// or <c>null</c> if the file is not found or an error occurs.
        /// </returns>
        public static T LoadJson<T>(string path) where T : class
        {
            try
            {
                if (File.Exists(path))
                {
                    string jsonData = File.ReadAllText(path);
                    return JsonConvert.DeserializeObject<T>(jsonData);
                }
                else
                {
                    Debug.LogWarning($"File {path} not found.");
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Error loading JSON data from {path}: {e.Message}");
                return null;
            }
        }

        /// <summary>
        /// Deletes the file at the specified path if it exists.
        /// </summary>
        /// <param name="path">The file path to delete.</param>
        /// <returns>
        /// <c>true</c> if the file was found and deleted; otherwise, <c>false</c>.
        /// </returns>
        public static bool DeleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Debug.LogError($"Error deleting file {path}: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// Deletes the specified directory and its contents if it exists.
        /// </summary>
        /// <param name="path">The directory path to delete.</param>
        /// <param name="recursive">
        /// If set to <c>true</c>, deletes all subdirectories and files in the directory; otherwise, only deletes the directory if it is empty.
        /// </param>
        /// <returns>
        /// <c>true</c> if the directory was found and deleted; otherwise, <c>false</c>.
        /// </returns>
        public static bool DeleteDir(string path, bool recursive = true)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, recursive);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Debug.LogError($"Error deleting directory {path}: {e.Message}");
                return false;
            }
        }
    }
}
