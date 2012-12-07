using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
namespace CCMS.Helpers
{
    /// <summary>
    /// ReflectionHelper
    /// ������
    /// 
    /// �޸ļ�¼
    ///   
    ///         2010.8.9 �汾��1.0 �׵�˧ ����
    /// 
    /// �汾��1.0
    /// 
    /// <author>
    ///        <name>�׵�˧</name>
    ///        <date>2010.8.9</date>
    /// </author> 
    /// </summary>
    public class ReflectionHelper
    {
        #region ����ָ��Ŀ¼����������
        /// <summary>
        ///  ����ָ��Ŀ¼�����г����е�����������baseType������
        /// </summary>
        /// <typeparam name="baseType">���ࣨ��ӿڣ�����</typeparam>
        /// <param name="directorySearched">������Ŀ¼</param>
        /// <param name="searchChildFolder">�Ƿ�������Ŀ¼�еĳ���</param>
        /// <param name="config">�߼����ã����Դ���null����Ĭ������</param>        
        /// <returns>���д�BaseType�����������б�</returns>
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

                #region Asm ���س��򼯵��ڴ���
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

                #region Asm ���س��򼯵��ڴ���
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

        #region �������ڴ�
        private bool copyToMemory = false;
        /// <summary>
        /// CopyToMem �Ƿ񽫳��򼯿������ڴ�����
        /// </summary>
        public bool CopyToMemory
        {
            get { return copyToMemory; }
            set { copyToMemory = value; }
        }
        #endregion

        #region ���س�������
        private bool loadAbstractType = false;
        /// <summary>
        /// LoadAbstractType �Ƿ���س�������
        /// </summary>
        public bool LoadAbstractType
        {
            get { return loadAbstractType; }
            set { loadAbstractType = value; }
        }
        #endregion

        #region Ŀ����򼯵ĺ�׺��
        private string targetFilePostfix = ".dll";
        /// <summary>
        /// TargetFilePostfix ������Ŀ����򼯵ĺ�׺��
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
