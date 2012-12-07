using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Menu.Help.Plugins.CheckUpdate
{
    public class RemoteFile
    {
        #region The private fields
        private string path = "";
        private string url = "";
        private string lastver = "";
        private int size = 0;
        private bool needRestart = false;
        #endregion

        #region The public property
        public string Path { get { return path; }set{path=value;} }
        public string Url { get { return url; } set { url = value; } }
        public string LastVer { get { return lastver; } set { lastver = value; } }
        public int Size { get { return size; } set { size = value; } }
        public bool NeedRestart { get { return needRestart; } set { needRestart = value; } }
        #endregion
        public RemoteFile()
        { }
        #region The constructor of AutoUpdater
        public RemoteFile(XmlNode node)
        {
            this.path = node.Attributes["Path"].Value;
            this.url = node.Attributes["Url"].Value;
            this.lastver = node.Attributes["LastVer"].Value;
            this.size = Convert.ToInt32(node.Attributes["Size"].Value);
            this.needRestart = Convert.ToBoolean(node.Attributes["NeedRestart"].Value);
        }
        #endregion
    }
}
