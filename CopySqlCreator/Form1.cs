using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopySqlCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetDummyData();
        }

        void SetDummyData()
        {
            tbxServerDest.Text = "vm2016-t01";
            tbxDbDest.Text = "TestDB02";
            tbxUserDest.Text = "test";
            mtbxPasswordDest.Text = "test1";

            tbxDbSource.Text = "TestDB01";
            tbxSchemaSource.Text = "dbo";

            cbxLinkServerOnOff.Checked = false;
            tbxLinkServer.Enabled = false;  // 起動時はイベントが実行されないので、強制的に無効化

            tbxOutputSql.Text = @"C:\outsql\";
        }

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
    }
}
