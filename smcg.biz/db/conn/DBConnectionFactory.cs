using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smcg.biz.conf;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace smcg.biz.db.conn
{
    public class DBConnectionFactory
    {
        public static DbConnection getConnection(DBConfig config)
        { 
            string connStr = String.Format(
                "server={0};user id={1}; password={2}; database={3}; pooling=false",
                config.Server, config.UserName, config.Password, config.DBName);

            DbConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
