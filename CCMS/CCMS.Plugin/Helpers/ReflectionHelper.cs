using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
namespace CCMS.Helpers
{
    /// <summary>
    /// ReflectionHelper
    /// 反射类
    /// 
    /// 修改纪录
    ///   
    ///         2010.8.9 版本：1.0 孔德帅 创建
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    ///        <name>孔德帅</name>
    ///        <date>2010.8.9</date>
    /// </author> 
    /// </summary>
    public class ReflectionHelper
    {
        #region 加载指定目录下派生类型
        /// <summary>
        ///  加载指定目录下所有程序集中的所有派生自baseType的类型
        /// </summary>
        /// <typeparam name="baseType">基类（或接口）类型</typeparam>
        /// <param name="directorySearched">搜索的目录</param>
        /// <param name="searchChildFolder">是否搜索子目录中的程序集</param>
        /// <param name="config">高级配置，可以传入null采用默认配置</param>        
        /// <returns>所有从BaseType派生的类型列表</returns>
        public static IList<Type> LoadDerivedType(Type baseType, string directorySearched, bool searchChildFolder, TypeLoadConfig config)
        {
            if (config == null)
            {
                config = new TypeLoadConfig();
            }

            IList<Type> derivedTypeList = new List<Type>();
            if (searchChildFolder)
            {
                ReflectionHelper.LoadDerivedTypeInAllFolder(baseType, derivedTypeList, directorySearched, config);
            }
            else
            {
                ReflectionHelper.LoadDerivedTypeInOneFolder(baseType, derivedTypeList, directorySearched, config);
            }

            return derivedTypeList;
        }
        #endregion

        #region LoadDerivedTypeInAllFolder
        private static void LoadDerivedTypeInAllFolder(Type baseType, IList<Type> derivedTypeList, string folderPath, TypeLoadConfig config)
        {
            ReflectionHelper.LoadDerivedTypeInOneFolder(baseType, derivedTypeList, folderPath, config);
            string[] folders = Directory.GetDirectories(folderPath);
            if (folders != null)
            {
                foreach (string nextFolder in folders)
                {
                    ReflectionHelper.LoadDerivedTypeInAllFolder(baseType, derivedTypeList, nextFolder, config);
                }
            }
        }
        #endregion


        #region LoadAssembly
        public static void LoadDerivedTypeInAllFolder(string folderPath, TypeLoadConfig config)
        {
            ReflectionHelper.LoadAssemblyInOneFolder(folderPath, config);
            string[] folders = Directory.GetDirectories(folderPath);
            if (folders != null)
            {
                foreach (string nextFolder in folders)
                {
                    ReflectionHelper.LoadAssemblyInOneFolder(nextFolder, config);
                }
            }
        }
        public static void LoadAssemblyInOneFolder(string folderPath, TypeLoadConfig config)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                if (config.TargetFilePostfix != null)
                {
                    if (!file.EndsWith(config.TargetFilePostfix))
                    {
                        continue;
                    }
                }

                Assembly asm = null;

                #region Asm 加载程序集到内存中
                try
                {
                    if (config.CopyToMemory)
                    {
                        byte[] addinStream = FileHelper.ReadFileReturnBytes(file);
                        asm = Assembly.Load(addinStream);
                    }
                    else
                    {
                        asm = Assembly.LoadFrom(file);
                    }
                }
                catch
                {

                }

                if (asm == null)
                {
                    continue;
                }
                #endregion
            }
        }
        #endregion

        #region LoadDerivedTypeInOneFolder

        private static void LoadDerivedTypeInOneFolder(Type baseType, IList<Type> derivedTypeList, string folderPath, TypeLoadConfig config)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                if (config.TargetFilePostfix != null)
                {
                    if (!file.EndsWith(config.TargetFilePostfix))
                    {
                        continue;
                    }
                }

                Assembly asm = null;

                #region Asm 加载程序集到内存中
                try
                {
                    if (config.CopyToMemory)
                    {
                        byte[] addinStream = FileHelper.ReadFileReturnBytes(file);
                        asm = Assembly.Load(addinStream);
                    }
                    else
                    {
                        asm = Assembly.LoadFrom(file);
                    }
                }
                catch
                {
                    
                }

                if (asm == null)
                {
                    continue;
                }
                #endregion

                Type[] types = asm.GetTypes();

                foreach (Type t in types)
                {
                    if (t.IsSubclassOf(baseType) || baseType.IsAssignableFrom(t))
                    {
                        bool canLoad = config.LoadAbstractType ? true : (!t.IsAbstract);
                        if (canLoad)
                        {
                            derivedTypeList.Add(t);
                        }
                    }
                }
            }

        }
        #endregion
        
    }
    #region TypeLoadConfig
    public class TypeLoadConfig
    {
        #region Ctor
        public TypeLoadConfig() { }
        public TypeLoadConfig(bool copyToMem, bool loadAbstract, string postfix)
        {
            this.copyToMemory = copyToMem;
            this.loadAbstractType = loadAbstract;
            this.targetFilePostfix = postfix;
        }
        #endregion

        #region 拷贝到内存
        private bool copyToMemory = false;
        /// <summary>
        /// CopyToMem 是否将程序集拷贝到内存后加载
        /// </summary>
        public bool CopyToMemory
        {
            get { return copyToMemory; }
            set { copyToMemory = value; }
        }
        #endregion

        #region 加载抽象类型
        private bool loadAbstractType = false;
        /// <summary>
        /// LoadAbstractType 是否加载抽象类型
        /// </summary>
        public bool LoadAbstractType
        {
            get { return loadAbstractType; }
            set { loadAbstractType = value; }
        }
        #endregion

        #region 目标程序集的后缀名
        private string targetFilePostfix = ".dll";
        /// <summary>
        /// TargetFilePostfix 搜索的目标程序集的后缀名
        /// </summary>
        public string TargetFilePostfix
        {
            get { return targetFilePostfix; }
            set { targetFilePostfix = value; }
        }
        #endregion
    }
    #endregion
}
