using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ApplicationLogic.Helpers
{
    /// <summary>
    /// Zawiera funkcje kryptograficzne.
    /// </summary>
    public static class CryptographyFunctions
    {
        /// <summary>
        /// Metoda wyciąga funkcję skrótu sha256 z łańcucha wejściowego.
        /// </summary>
        /// <param name="input">String jawny.</param>
        /// <returns>Funkcja skrótu sha256.</returns>
        public static string StrToHash(string input)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = string.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(input), 0, Encoding.ASCII.GetByteCount(input));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }

        /// <summary>
        /// Odmaskowuje string wejściowy.
        /// </summary>
        internal static byte[] Decrypt(string encrypted)
        {
            return Convert.FromBase64String(encrypted);
        }

        /// <summary>
        /// Zamaskowuje wejściową tablicę do stringa.
        /// </summary>
        internal static string Encypt(byte[] rawByte)
        {
            return Convert.ToBase64String(rawByte);
        }       
    }
}
