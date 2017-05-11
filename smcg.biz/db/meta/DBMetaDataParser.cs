using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smcg.biz.conf;
using System.Data.Common;
using smcg.biz.db.conn;
using smcg.biz.db.entity;
using MySql.Data.MySqlClient;

namespace smcg.biz.db
{
    public abstract class DBMetaDataParser
    {
        protected DBConfig config;
        private DbConnection conn;

        public DBMetaDataParser(DBConfig config) 
        {
            this.config = config;
            conn = DBConnectionFactory.getConnection(config);
            conn.Open();
        }

        public List<T> GetEntityList<T>() where T : new()
        {
            return GetEntityList<T>(null);
        }

        public List<T> GetEntityList<T>(String[] args) where T : new()
        {
            List<T> list = new List<T>();
            DbDataReader reader = null;
            DbCommand cmd = GetCommand<T>(args,conn);
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(ConstructEntity<T>(reader));
                }
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            return list;
        }

        public void disposeResource() 
        { 
            if(conn != null)
            {
                conn.Close();
            }
        }

        protected abstract DbCommand GetCommand<T>(String[] args,DbConnection conn);
        protected abstract T ConstructEntity<T>(DbDataReader reader) where T : new();

    }
}
