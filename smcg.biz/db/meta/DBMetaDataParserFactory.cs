using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smcg.biz.conf;
using smcg.biz.db.impl;

namespace smcg.biz.db.meta
{
    public class DBMetaDataParserFactory
    {
        public static DBMetaDataParser getMetaDataParser(DBConfig config) 
        {
            return new MySQLMetaDataParser(config);
        }
    }
}
