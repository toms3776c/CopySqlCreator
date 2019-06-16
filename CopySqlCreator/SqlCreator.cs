using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopySqlCreator
{
    class SqlCreator
    {
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


        public bool CreateSql()
        {
            // DB接続


            // テーブル一覧取得


            //


            //


            //


            return true;
        }
    }
}
