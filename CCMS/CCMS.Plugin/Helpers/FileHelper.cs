using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CCMS.Helpers
{
   public class FileHelper
    {
        #region ReadFileReturnBytes
        /// <summary>
        /// ReadFileReturnBytes 从文件中读取二进制数据
        /// </summary>      
        public static byte[] ReadFileReturnBytes(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            BinaryReader br = new BinaryReader(fs);

            byte[] buff = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return buff;
        }
        #endregion

        public static string GetFileNameNoPath(string fileName_path)
        {
            return Path.GetFileName(fileName_path);
        }
    }
}
