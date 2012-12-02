using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Configuration;
namespace DNCCFrameWork.DataAccess
{
    public class DbFactory
    {

        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //private static readonly string ConnectionString = @"GCdjGuQBUMyextfrXW9EGGCJInaTaeLs8Y6B3dPKSaMmD+rlFes9azdJdom/98hR";
        //private string DbProviderString = ConfigurationManager.AppSettings["DbProvider"].ToString();

        private static readonly string DbProviderString = "SqlHelper";
        public IDbHelper IDbHelper = null;

        #region 构造函数

        public DbFactory()
        {
            BaseDbHelper baseHelper = (BaseDbHelper)Assembly.Load("CCMS.Common").CreateInstance("DNCCFrameWork.DataAccess.DbProvider." + DbProviderString);
            //baseHelper.ConnectionString =FX.Core.Helpers.CryptoTextBase.ProcessText(ConnectionString,false);
            IDbHelper = baseHelper;
        }

        #endregion
    }
}
