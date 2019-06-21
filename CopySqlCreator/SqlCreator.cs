using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopySqlCreator
{
    class SqlCreator
    {
        readonly string FileSuffixNormalCopy = "_TableCopy.sql";
        readonly string FileSuffixLinkServerCopy = "_LinkTableCopy.sql";

        private DBManagerForSQLServer dbManager;    // クラス全体でデータ検索に使用するため、フィールド変数として用意。

        private string dbServerDest = "";
        private string dbNameDest = "";
        private string dbUser = "";
        private string dbPassword = "";

        private string dbNameSource = "";
        private string dbSchemaSource = "";
        private string dbLinkServer = "";

        private string outputSqlFolder = "";


        public SqlCreator(SqlCreatorConfig config)
        {
            dbServerDest = config.ServerDest;
            dbNameDest = config.DbDest;
            dbUser = config.User;
            dbPassword = config.Password;

            dbNameSource = config.DbSource;
            dbSchemaSource = config.SchemaSource;
            dbLinkServer = config.LinkServerSource;

            outputSqlFolder = config.OutputSqlFolder;
        }




        private bool OutputSql(string sql, string table)
        {
            string filePath = "";
            if (dbLinkServer != "")
            {
                filePath = Path.Combine(outputSqlFolder, table + FileSuffixNormalCopy);
            }
            else
            {
                filePath = Path.Combine(outputSqlFolder, table + FileSuffixLinkServerCopy);
            }
            
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.GetEncoding("Shift_JIS")))
            {
                try
                {
                    writer.WriteLine(sql);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }



        private string CreateTableCopySql(string table, string fields, int identityFlag, string dropIndexSql, string createIndexSql)
        {
            string sql = "";
            sql += "/*\n";
            sql += "  このSQLは xxx より作成されました。\n";
            sql += "\n";
            sql += "  ツールバージョン： xxxxx";
            sql += "\n";
            sql += "*/\n";
            
            sql += "USE " + dbNameDest + "\n";
            sql += "GO\n\n";

            sql += "TRUNCATE TABLE " + table + "\n\n";

            if (dropIndexSql != "")
            {
                sql += "\n";
            }

            if (identityFlag == 1)
            {
                sql += "set identity_insert " + table + " on\n\n";
            }

            sql += "INSERT INTO " + table + "(\n";
            sql += "  " + fields + "\n";
            sql += ")\n";
            sql += "SELECT\n";
            sql += "  " + fields + "\n";
            sql += "FROM\n";
            sql += "  ";

            if (dbLinkServer == "")
            {
                sql += "[" + dbNameSource + "].[" + dbSchemaSource + "].[" + table + "]";
                sql += "\n\n";
            }
            else
            {
                sql += "[" + dbLinkServer + "].[" + dbNameSource + "].[" + dbSchemaSource + "].[" + table + "]";
                sql += "\n\n";
            }

            if (identityFlag == 1)
            {
                sql += "set identity_insert " + table + " off\n\n";
            }

            if (createIndexSql != "")
            {
                sql += "\n";
            }

            
            sql += "\n";

            return sql;
        }










        private string GetFieldDefinition(string table)
        {
            string sql = "";
            sql += "select  c.name c_name, c.column_id ";
            sql += "from    sys.tables t left join sys.columns c on ";
            sql += "          t.object_id=c.object_id ";
            sql += "where    t.name='" + table + "' ";
            sql += "order by c.column_id";
            sql += "";

            string fields = "";
            var reader = dbManager.ExecuteQuery(sql);
            while (reader.Read())
            {
                fields += "[" + reader["c_name"].ToString() + "], ";
            }
            fields = fields.Substring(0, fields.Length - 2);    // 最後のカンマを削除

            return fields;
        }

        private List<string> GetTableLists()
        {
            string sql = "";
            sql += "select   name ";
            sql += "from     sys.tables ";
            sql += "where    type = 'U' ";
            sql += "order by name ";
            sql += "";

            var reader = dbManager.ExecuteQuery(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader["name"].ToString());
            }

            return list;
        }


        public bool CreateSql(ref string procMessage)
        {
            // DB接続
            dbManager = new DBManagerForSQLServer(dbServerDest, dbNameDest, dbUser, dbPassword);
            if (!dbManager.Open())
            {
                procMessage = "DB [" + dbServerDest + "] への接続に失敗しました。";
                return false;
            }

            // テーブル一覧取得
            List<string> tables = new List<string>();
            tables = GetTableLists();
            if (tables.Count == 0)
            {
                procMessage = "対象となるテーブルが見つかりませんでした。";
                return false;
            }

            foreach (var table in tables)
            {
                // テーブル別のフィールド取得
                string fields = GetFieldDefinition(table);

                //

                //

                //

                // SQLを組み立て
                string outputSql = CreateTableCopySql(table, fields, 0, "", "");

                // SQLを出力
                if (!OutputSql(outputSql, table))
                {
                    // TODO:出力エラーの一覧を検討する（別フォームで一覧作成？）

                }
            }


            dbManager.Close();

            procMessage = "コピーSQLが作成されました。";
            return true;
        }
    }
}
