using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CCMS.UI
{
   public class TreeDataSet
    {
       private DataSet ds = new DataSet();

       public TreeDataSet()
       {
           createDataSet();
       }
       private void createDataSet()
       {
           DataTable dt = new DataTable("Module");
           DataColumn id = new DataColumn("Id");
           DataColumn name = new DataColumn("Name");
           DataColumn className = new DataColumn("Classname");
           DataColumn order = new DataColumn("MOrder",typeof(int));
           DataColumn paranetId = new DataColumn("ParanetId");
           DataColumn enable = new DataColumn("Enable");
           DataColumn moduleType = new DataColumn("ModuleType");
           dt.Columns.AddRange(new DataColumn[] { id, name, className, order, paranetId, enable, moduleType });
           ds.Tables.Add(dt);
       }
       public void Add(Module m)
       {
           if (m != null)
           {
               DataRow[] rows = ds.Tables[0].Select("Id='" + m.Id + "' and ParanetId='" + m.ParanetId + "' and ModuleType='" + m.ModuleType+"'");
               if (rows == null || rows.Length <= 0)
               {
                   DataRow r = ds.Tables[0].NewRow();
                   r["Id"] = m.Id;
                   r["Name"] = m.Name;
                   r["Classname"] = m.ClassName;
                   r["MOrder"] = m.Order;
                   r["ParanetId"] = m.ParanetId;
                   r["Enable"] = m.Enable;
                   r["ModuleType"] = m.ModuleType;
                   ds.Tables[0].Rows.Add(r);
               }
           }
       }
       public DataSet GetDataSet()
       {
           return ds;
       }
    }
   public class Module
   {
       private string moduleType;

       public string ModuleType
       {
           get { return moduleType; }
           set { moduleType = value; }
       }
       private bool enable = true;

       public bool Enable
       {
           get { return enable; }
           set { enable = value; }
       }
       public Module()
       { }
       public Module(string id, string name, string className, int order, string paranetId)
       {
           this.id = id;
           this.name = name;
           this.className = className;
           this.order = order;
           this.paranetId = paranetId;
        }
       private string id;

       public string Id
       {
           get { return id; }
           set { id = value; }
       }
       private string name;

       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       private string className;

       public string ClassName
       {
           get { return className; }
           set { className = value; }
       }
       private int order;

       public int Order
       {
           get { return order; }
           set { order = value; }
       }
       private string paranetId;

       public string ParanetId
       {
           get { return paranetId; }
           set { paranetId = value; }
       }
       
   }
}
