using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace TrinityCore_Manager.Security
{
    public static class SecurityExtensions
    {

        public static string ToSHA1(this string str)
        {

            byte[] keyArray = Encoding.UTF8.GetBytes(str);
            
            var enc = new SHA1Managed();
            
            byte[] encodedKey = enc.ComputeHash(enc.ComputeHash(keyArray));
            
            var sb = new StringBuilder(encodedKey.Length);

            foreach (byte b in encodedKey)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();

        }

        public static string EncryptString(this SecureString input, byte[] entropy)
        {
            if (input == null)
            {
                return null;
            }

            var encryptedData = ProtectedData.Protect(
                Encoding.Unicode.GetBytes(input.ToInsecureString()),
                entropy,
                DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(this string encryptedData, byte[] entropy)
        {
            if (encryptedData == null)
            {
                return null;
            }

            try
            {
                var decryptedData = ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    DataProtectionScope.CurrentUser);

                return Encoding.Unicode.GetString(decryptedData).ToSecureString();
            }
            catch
            {
                return new SecureString();
            }
        }

        public static SecureString ToSecureString(this IEnumerable<char> input)
        {
            if (input == null)
            {
                return null;
            }

            var secure = new SecureString();

            foreach (var c in input)
            {
                secure.AppendChar(c);
            }

            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(this SecureString input)
        {
            if (input == null)
            {
                return null;
            }

            var ptr = Marshal.SecureStringToBSTR(input);

            try
            {
                return Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ptr);
            }
        }

    }
}
