using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smcg.biz.conf
{
    public class DBConfig
    {
        public string ProjectDir { get; set; }
        public string DBType { get; set; }
        public string DBVersion { get; set; }

        private String url;
        public string Url {
            get 
            {
                return url;
            }
            set 
            {
                value = value.Substring(value.IndexOf("/") + 2);
                DBName = value.Substring(value.LastIndexOf("/")+1);
                Server = value.Substring(0, value.IndexOf(":"));
                url = value;
            } 
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DBName { get; set; }
        public String Server { get; set; }
    }
}
