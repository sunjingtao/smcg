using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using smcg.biz.conf;
using smcg.biz.db;
using smcg.biz.db.meta;
using smcg.biz.db.entity;
namespace smcg
{
    public partial class mainForm : Form
    {
        private DBConfig config = new DBConfig();
        private DBMetaDataParser metaDataParser;
        private List<DBTable> tableList;
        private Dictionary<String, List<DBColumn>> tableColumnDictionary;

        public mainForm(String[] args)
        {
            args = new String[] { 
            "file://E:/projects/myproject/java/idea-plugin/smcodegenerator",
            "MySQL",
            "5.6.29",
            "jdbc:mysql://localhost:3306/hisense_tap",
            "root",
            "123456a?"
            };
            InitializeComponent();
            config.ProjectDir = args[0];
            config.DBType = args[1];
            config.DBVersion = args[2];
            config.Url = args[3];
            config.UserName = args[4];
            config.Password = args[5];
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.tableDataGridView.AutoGenerateColumns = false;

            metaDataParser = DBMetaDataParserFactory.getMetaDataParser(config);
            tableList = metaDataParser.GetEntityList<DBTable>();
            tableDataGridView.DataSource = tableList;

            tableColumnDictionary = new Dictionary<string, List<DBColumn>>(tableList.Count);
        }

        private void tableDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            tableList[e.RowIndex].Status = tableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString() == "true";
        }

        private void tableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String tableName = tableList[e.RowIndex].Name;
            List<DBColumn> columnList = tableColumnDictionary.ContainsKey(tableName) ? tableColumnDictionary[tableName] : null;
            if (columnList == null)
            {
                columnList = metaDataParser.GetEntityList<DBColumn>(new String[2]{tableName,config.DBName});
                tableColumnDictionary[tableName] = columnList;
            }
            tableColumnsGrid.DataSource = columnList;
        }


    }
}
