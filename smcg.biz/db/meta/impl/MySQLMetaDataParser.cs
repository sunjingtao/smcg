using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smcg.biz.conf;
using System.Data.Common;
using smcg.biz.db.entity;
using MySql.Data.MySqlClient;

namespace smcg.biz.db.impl
{
    public class MySQLMetaDataParser : DBMetaDataParser
    {
        public MySQLMetaDataParser(DBConfig config) : base(config)
        {
            
        }


        protected override DbCommand GetCommand<T>(String[] args,DbConnection conn)
        {
            if(typeof(T) == typeof(DBTable))
            {
                return new MySqlCommand("SHOW TABLES", (MySqlConnection)conn);
            }
            if (typeof(T) == typeof(DBColumn))
            {
                return new MySqlCommand(
                    String.Format("select COLUMN_NAME,DATA_TYPE,COLUMN_COMMENT from information_schema.COLUMNS where table_name = '{0}' and TABLE_SCHEMA= '{1}'",args[0],args[1])
                    , (MySqlConnection)conn);
            }
            return null;
        }

        protected override T ConstructEntity<T>(DbDataReader reader)
        {
            T t = new T();
            if (typeof(T) == typeof(DBTable))
            {
                DBTable table =  t as DBTable;
                table.Name = reader.GetString(0);              
            }
            if (typeof(T) == typeof(DBColumn))
            {
                DBColumn column = t as DBColumn;
                column.Name = reader["COLUMN_NAME"].ToString();
                column.Comment = reader["COLUMN_COMMENT"].ToString();
            }
            return t;
        }
    }
}
