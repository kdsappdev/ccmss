using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;
namespace CCMS.Helpers
{
    /// <summary>
    /// CryptoTextBase
    /// 加密解密算法
    /// 
    /// 修改纪录
    ///  
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    ///        <name>孔德帅</name>
    ///        <date>2009.12.13</date>
    /// </author> 
    public class CryptoTextBase
    {
        // A larger salt would provide more secure encryption here
        private static readonly byte[] SaltBytes = { 0x39, 0x38, 0x14, 0x05, 0x68 };
        private static byte[] _pwd;

        private static MemoryStream _ms;
        private static CryptoStream _cs;
        protected static Byte[] Password { get { return _pwd; } }
        protected static MemoryStream MStream { get { return _ms; } set { _ms = value; } }
        protected static CryptoStream CStream { get { return _cs; } set { _cs = value; } }

        public CryptoTextBase(string password)
        {
            if (password == null || password.Length == 0)
                throw new ArgumentNullException("password");
            _pwd = Encoding.UTF8.GetBytes(password);
        }
       public CryptoTextBase()
        { }
        static CryptoTextBase()
        {
            string password ="DNCC";
            string temp = ConfigurationManager.AppSettings["Security"];
            if(!string.IsNullOrEmpty(temp)) password=temp;
            _pwd = Encoding.UTF8.GetBytes(password);
        }
        /// <summary>
        /// Encrypt or decrypt a given string
        /// </summary>
        public static string ProcessText(string text, bool encrypt)
        {
            // Encode text as byte array
            byte[] bytes = encrypt ? Encoding.UTF8.GetBytes(text)
              : Convert.FromBase64String(text);

            MStream = new MemoryStream();
            // Create default symmetric algorithm for cryption
            SymmetricAlgorithm alg = SymmetricAlgorithm.Create();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, SaltBytes);
            alg.Key = pdb.GetBytes(alg.KeySize / 8);
            alg.IV = pdb.GetBytes(alg.BlockSize / 8);

            ICryptoTransform transform
              = encrypt ? alg.CreateEncryptor() : alg.CreateDecryptor();

            // Create cryptographic stream
            CStream = new CryptoStream(MStream,
              transform,
              CryptoStreamMode.Write);

            // Encrypt data and flush result to buffer
            CStream.Write(bytes, 0, bytes.Length);
            CStream.FlushFinalBlock();

            // Retrieve the resulting bytes
            byte[] result = MStream.ToArray();

            // Convert result to a string
            return encrypt
              ? Convert.ToBase64String(result)
              : Encoding.UTF8.GetString(result);
        }
        public static byte[] ProcessText(byte[] bytes, bool encrypt)
        {     

            MStream = new MemoryStream();
            // Create default symmetric algorithm for cryption
            SymmetricAlgorithm alg = SymmetricAlgorithm.Create();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, SaltBytes);
            alg.Key = pdb.GetBytes(alg.KeySize / 8);
            alg.IV = pdb.GetBytes(alg.BlockSize / 8);

            ICryptoTransform transform
              = encrypt ? alg.CreateEncryptor() : alg.CreateDecryptor();

            // Create cryptographic stream
            CStream = new CryptoStream(MStream,
              transform,
              CryptoStreamMode.Write);

            // Encrypt data and flush result to buffer
            CStream.Write(bytes, 0, bytes.Length);
            CStream.FlushFinalBlock();

            // Retrieve the resulting bytes
            byte[] result = MStream.ToArray();

            // Convert result to a string
            return result;
            
        }
    }
}
