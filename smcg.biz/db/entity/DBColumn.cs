using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smcg.biz.db.entity
{
    public class DBColumn
    {
        private string name;
        public string Name 
        {
            get { return name; } 
            set
            {
                name = value;
                string[] nameStrs = name.Split('_');
                EntityName = nameStrs[0].ToLower();
                if (nameStrs.Length > 1) {
                    for (int i = 1; i < nameStrs.Length; i++)
                    {
                        EntityName += nameStrs[i].Substring(0, 1).ToUpper() + nameStrs[i].Substring(1).ToLower();
                    }
                }
            }
        }
        public string Comment { get; set; }
        public bool Status { get; set; }
        public string EntityName { get; set; }
    }
}
