using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CopySqlCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetDummyData();

            if (cbxLinkServerOnOff.Checked)
            {
                tbxLinkServer.Enabled = true;
            }
            else
            {
                tbxLinkServer.Enabled = false;
            }
        }

        /// <summary>
        /// ツール開発用のダミーデータをセットする
        /// </summary>
        void SetDummyData()
        {
            tbxServerDest.Text = "vm2016-t01";
            tbxDbDest.Text = "TestDB02";
            tbxUserDest.Text = "test";
            mtbxPasswordDest.Text = "test1";

            tbxDbSource.Text = "TestDB01";
            tbxSchemaSource.Text = "dbo";

            cbxLinkServerOnOff.Checked = false;
            //tbxLinkServer.Enabled = false;  // 起動時はイベントが実行されないので、強制的に無効化

            tbxOutputSqlFolder.Text = @"C:\outsql\";
        }

        /// <summary>
        /// リンクサーバー経由コピーSQLを作成するかのチェックボックスON/OFF処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLinkServerOnOff_CheckedChanged(object sender, EventArgs e)
        {
            //(CheckBox)sender as CheckBox;
            CheckBox cbx = (CheckBox)sender;

            if (cbx.Checked)
            {
                tbxLinkServer.Enabled = true;
            }
            else
            {
                tbxLinkServer.Enabled = false;
            }

        }

        /// <summary>
        /// コピーSQL出力ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOutputSql_Click(object sender, EventArgs e)
        {
            // 入力値のチェック
            if (!IsInputValueAppropriate())
            {
                return;
            }
            
            //// SQL作成処理
            //SqlCreator sqlCreator_x = new SqlCreator(
            //    tbxServerDest.Text.Trim(),
            //    tbxDbDest.Text.Trim(),
            //    tbxUserDest.Text.Trim(),
            //    mtbxPasswordDest.Text.Trim(),
            //    "");

            string linkServer = "";
            if (cbxLinkServerOnOff.Checked)
            {
                linkServer = tbxLinkServer.Text.Trim();
            }
            SqlCreatorConfig config = new SqlCreatorConfig(
                tbxServerDest.Text.Trim(), tbxDbDest.Text.Trim(), tbxUserDest.Text.Trim(), mtbxPasswordDest.Text.Trim(),
                tbxDbSource.Text.Trim(), tbxSchemaSource.Text.Trim(), linkServer,
                tbxOutputSqlFolder.Text.Trim());

            SqlCreator sqlCreator = new SqlCreator(config);
            sqlCreator.CreateSql();

        }

        /// <summary>
        /// 各入力値のチェック処理
        /// </summary>
        /// <returns></returns>
        private bool IsInputValueAppropriate()
        {
            const string DialogTitle = "入力値チェックエラー";

            if (tbxServerDest.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー先]サーバー名が入力されていません", DialogTitle);
                return false;
            }
            if (tbxDbDest.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー先]データベース名が入力されていません", DialogTitle);
                return false;
            }
            if (tbxUserDest.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー先]ユーザーが入力されていません", DialogTitle);
                return false;
            }
            if (mtbxPasswordDest.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー先]パスワードが入力されていません", DialogTitle);
                return false;
            }
            if (tbxDbSource.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー元]データベース名が入力されていません", DialogTitle);
                return false;
            }
            if (tbxSchemaSource.Text.Trim() == "")
            {
                Common.MessageShowError("[コピー元]スキーマ名が入力されていません", DialogTitle);
                return false;
            }

            if (cbxLinkServerOnOff.Checked == true)
            {
                if (tbxLinkServer.Text.Trim() == "")
                {
                    Common.MessageShowError("[コピー元]リンクサーバー名が入力されていません", DialogTitle);
                    return false;
                }
            }

            if (tbxOutputSqlFolder.Text.Trim() == "")
            {
                Common.MessageShowError("SQL出力フォルダが入力されていません", DialogTitle);
                return false;
            }
            if (!System.IO.Directory.Exists(tbxOutputSqlFolder.Text.Trim()))
            {
                Common.MessageShowError("SQL出力フォルダが存在しません", DialogTitle);
                return false;
            }

            return true;
        }
            
    }
}
