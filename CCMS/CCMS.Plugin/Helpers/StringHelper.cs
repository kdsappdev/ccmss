using System;
using System.Collections.Generic;
using System.Text;

namespace IM.CM.Helpers
{
   public class StringHelper
   {
       #region ×Ö·û´® ×Ö½ÚÁ÷ »¥»»

       #region ×Ö·û´®×ª»¯Îª×Ö½Ú
       public static byte[] StringToByte(string str)
       {
           byte[] b = null;
           if (IsNullOrEmpty(str))
           {
               b = new byte[0];
           }
           else
           {
               b = Encoding.Default.GetBytes(str);
           }
           return b;
       }
       #endregion

       #region ×Ö½Ú×ª»¯Îª×Ö·û´®
       public static string BytesToString(byte[] b,int index,int count)
       {
           string str = "";
           if (b != null)
           {
               str = Encoding.Default.GetString(b, index, count);
           }
           return str;
       }
       public static string BytesToString(byte[] b)
       {
          return BytesToString(b, 0, b.Length);
       }
       #endregion

       #endregion

       #region ÅĞ¶Ï×Ö·û´®ÊÇ·ñÎªNULL»ò¿Õ
       public static bool IsNullOrEmpty(string str)
       {
           bool isNULLOrEmpty = false;
           if (string.IsNullOrEmpty(str))
           {
               isNULLOrEmpty = true;
           }
           return isNULLOrEmpty;
       }
       #endregion

       #region ½ØÈ¡×Ö·û´®³¤¶È
       public string SubString(string str, int n)
       {
           string temp=str;
           if (str.Length > n)
           {
               str.Substring(0, n);
           }
           return str;
       }
       #endregion
   }
}
