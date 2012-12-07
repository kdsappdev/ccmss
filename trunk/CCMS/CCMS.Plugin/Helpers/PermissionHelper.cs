using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Permissions.Services;
using Permissions.Entity;
using Permissions.Web;
namespace CCMS.Helpers
{
    public class PermissionHelper
    {
        private PermissionHelper()
        { }
        static PermissionHelper permissionHelper = null;
        public static PermissionHelper Instance
        {
            get
            {
                if (permissionHelper == null)
                {
                    permissionHelper = new PermissionHelper();
                }
                return permissionHelper;
            }
        }
        public CurrentUserInfo cui = null;
        public IList Modules = new ArrayList();
        public IList Functions =  new ArrayList();
        public bool IsLogin = false;
        public void Login(string userName, string userPwd)
        {            
            cui= SystemServices.Login(userName, userPwd);
            if (cui != null)
            {
                IsLogin = true;
            }          
        }
        public void GetModuleList()
        {             
            if (cui != null)
            {
                Modules = PermissionsServices.GetModuleList(cui);
            }
             
        }
        public void GetFunctionList()
        {             
            if (cui != null)
            {
                Functions = PermissionsServices.GetFunctionList(cui);
            }             
        }
    }
}
