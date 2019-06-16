using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CopySqlCreator
{
    class DBManagerForSQLServer
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;

        /// <summary>
        /// コンストラクタ（DB接続）
        /// <para name="dbServer">DBサーバ名</para>
        /// <para name="dbName">DB名</para>
        /// <para name="dbUser">ユーザ名</para>
        /// <para name="dbPass">パスワード</para>
        /// </summary>
        public DBManagerForSQLServer(string dbServer, string dbName, string dbUser, string dbPassword)
        {
            // 接続文字列を生成
            string connectString =
            "Data Source = " + dbServer
            + ";Initial Catalog = " + dbName
            + ";User ID = " + dbUser
            + ";Password = " + dbPassword
            + ";MultipleActiveResultSets=True";

            // SqlConnection の新しいインスタンスを生成 (接続文字列を指定)
            this.sqlConnection = new SqlConnection(connectString);

            // データベース接続を開く
            this.sqlConnection.Open();
        }

        /// <summary>
        /// DB切断
        /// </summary>
        public void Close()
        {
            this.sqlConnection.Close();
            this.sqlConnection.Dispose();
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTran()
        {
            this.sqlTransaction = this.sqlConnection.BeginTransaction();
        }

        /// <summary>
        /// トランザクション　コミット
        /// </summary>
        public void CommitTran()
        {
            if (this.sqlTransaction.Connection != null)
            {
                this.sqlTransaction.Commit();
                this.sqlTransaction.Dispose();
            }
        }

        /// <summary>
        /// トランザクション　ロールバック
        /// </summary>
        public void RollBack()
        {
            if (this.sqlTransaction.Connection != null)
            {
                this.sqlTransaction.Rollback();
                this.sqlTransaction.Dispose();
            }
        }

        /// <summary>
        /// クエリー実行(OUTPUT項目あり)
        /// <para name="query">SQL文</para>
        /// <para name="paramDict">SQLパラメータ</para>
        /// </summary>
        public SqlDataReader ExecuteQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先、トランザクションの指定
            sqlCom.Connection = this.sqlConnection;
            sqlCom.Transaction = this.sqlTransaction;

            sqlCom.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCom.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            // SQLを実行
            SqlDataReader reader = sqlCom.ExecuteReader();

            return reader;
        }

        /// <summary>
        /// クエリー実行(OUTPUT項目あり)
        /// <para name="query">SQL文</para>
        /// </summary>
        public SqlDataReader ExecuteQuery(string query)
        {
            return this.ExecuteQuery(query, new Dictionary<string, Object>());
        }

        /// <summary>
        /// クエリー実行(OUTPUT項目なし)
        /// <para name="query">SQL文</para>
        /// <para name="paramDict">SQLパラメータ</para>
        /// </summary>
        public void ExecuteNonQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先、トランザクションの指定
            sqlCom.Connection = this.sqlConnection;
            sqlCom.Transaction = this.sqlTransaction;

            sqlCom.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCom.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            // SQLを実行
            sqlCom.ExecuteNonQuery();
        }
    }
}
