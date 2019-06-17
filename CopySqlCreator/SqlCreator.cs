﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopySqlCreator
{
    class SqlCreator
    {
        private DBManagerForSQLServer dbManager;    // クラス全体でデータ検索に使用するため、フィールド変数として用意。

        private string dbServerDest = "";
        private string dbNameDest = "";
        private string dbUser = "";
        private string dbPassword = "";

        private string dbNameSource = "";
        private string dbSchemaSource = "";
        private string dbLinkServer = "";

        private string outputSqlFolder = "";

        //public SqlCreator(string dbServer, string dbName, string dbUser, string dbPassword, string outputSqlFolder)
        //{
        //    this.dbServerDest = dbServer;
        //    this.dbNameDest = dbName;
        //    this.dbUser = dbUser;
        //    this.dbPassword = dbPassword;
        //    this.outputSqlFolder = outputSqlFolder;
        //}

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


        public bool CreateSql()
        {
            // DB接続
            dbManager = new DBManagerForSQLServer(dbServerDest, dbNameDest, dbUser, dbPassword);
            if (!dbManager.Open())
            {
                return false;
            }

            // テーブル一覧取得
            List<string> tables = new List<string>();
            tables = GetTableLists();

            //


            //


            //


            return true;
        }
    }
}
