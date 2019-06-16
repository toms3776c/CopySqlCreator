namespace CopySqlCreator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxDest = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxServerDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDbDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUserDest = new System.Windows.Forms.TextBox();
            this.mtbxPasswordDest = new System.Windows.Forms.MaskedTextBox();
            this.gbxSource = new System.Windows.Forms.GroupBox();
            this.tbxLinkServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSchemaSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDbSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxLinkServerOnOff = new System.Windows.Forms.CheckBox();
            this.tbxOutputSql = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOutputSql = new System.Windows.Forms.Button();
            this.btnSelectOutputFolder = new System.Windows.Forms.Button();
            this.gbxDest.SuspendLayout();
            this.gbxSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDest
            // 
            this.gbxDest.Controls.Add(this.mtbxPasswordDest);
            this.gbxDest.Controls.Add(this.tbxUserDest);
            this.gbxDest.Controls.Add(this.label4);
            this.gbxDest.Controls.Add(this.label3);
            this.gbxDest.Controls.Add(this.tbxDbDest);
            this.gbxDest.Controls.Add(this.label2);
            this.gbxDest.Controls.Add(this.tbxServerDest);
            this.gbxDest.Controls.Add(this.label1);
            this.gbxDest.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbxDest.Location = new System.Drawing.Point(12, 47);
            this.gbxDest.Name = "gbxDest";
            this.gbxDest.Size = new System.Drawing.Size(355, 170);
            this.gbxDest.TabIndex = 0;
            this.gbxDest.TabStop = false;
            this.gbxDest.Text = "コピー先";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "サーバー名";
            // 
            // tbxServerDest
            // 
            this.tbxServerDest.Location = new System.Drawing.Point(135, 36);
            this.tbxServerDest.Name = "tbxServerDest";
            this.tbxServerDest.Size = new System.Drawing.Size(184, 27);
            this.tbxServerDest.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "データベース名";
            // 
            // tbxDbDest
            // 
            this.tbxDbDest.Location = new System.Drawing.Point(135, 66);
            this.tbxDbDest.Name = "tbxDbDest";
            this.tbxDbDest.Size = new System.Drawing.Size(184, 27);
            this.tbxDbDest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ユーザー";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "パスワード";
            // 
            // tbxUserDest
            // 
            this.tbxUserDest.Location = new System.Drawing.Point(135, 96);
            this.tbxUserDest.Name = "tbxUserDest";
            this.tbxUserDest.Size = new System.Drawing.Size(184, 27);
            this.tbxUserDest.TabIndex = 6;
            // 
            // mtbxPasswordDest
            // 
            this.mtbxPasswordDest.Location = new System.Drawing.Point(135, 126);
            this.mtbxPasswordDest.Name = "mtbxPasswordDest";
            this.mtbxPasswordDest.PasswordChar = '*';
            this.mtbxPasswordDest.Size = new System.Drawing.Size(184, 27);
            this.mtbxPasswordDest.TabIndex = 7;
            // 
            // gbxSource
            // 
            this.gbxSource.Controls.Add(this.cbxLinkServerOnOff);
            this.gbxSource.Controls.Add(this.tbxLinkServer);
            this.gbxSource.Controls.Add(this.label6);
            this.gbxSource.Controls.Add(this.tbxSchemaSource);
            this.gbxSource.Controls.Add(this.label7);
            this.gbxSource.Controls.Add(this.tbxDbSource);
            this.gbxSource.Controls.Add(this.label8);
            this.gbxSource.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbxSource.Location = new System.Drawing.Point(373, 47);
            this.gbxSource.Name = "gbxSource";
            this.gbxSource.Size = new System.Drawing.Size(355, 170);
            this.gbxSource.TabIndex = 1;
            this.gbxSource.TabStop = false;
            this.gbxSource.Text = "コピー元";
            // 
            // tbxLinkServer
            // 
            this.tbxLinkServer.Location = new System.Drawing.Point(135, 131);
            this.tbxLinkServer.Name = "tbxLinkServer";
            this.tbxLinkServer.Size = new System.Drawing.Size(184, 27);
            this.tbxLinkServer.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "リンクサーバー名";
            // 
            // tbxSchemaSource
            // 
            this.tbxSchemaSource.Location = new System.Drawing.Point(135, 66);
            this.tbxSchemaSource.Name = "tbxSchemaSource";
            this.tbxSchemaSource.Size = new System.Drawing.Size(184, 27);
            this.tbxSchemaSource.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "スキーマ名";
            // 
            // tbxDbSource
            // 
            this.tbxDbSource.Location = new System.Drawing.Point(135, 36);
            this.tbxDbSource.Name = "tbxDbSource";
            this.tbxDbSource.Size = new System.Drawing.Size(184, 27);
            this.tbxDbSource.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "データベース名";
            // 
            // cbxLinkServerOnOff
            // 
            this.cbxLinkServerOnOff.AutoSize = true;
            this.cbxLinkServerOnOff.Location = new System.Drawing.Point(135, 99);
            this.cbxLinkServerOnOff.Name = "cbxLinkServerOnOff";
            this.cbxLinkServerOnOff.Size = new System.Drawing.Size(140, 23);
            this.cbxLinkServerOnOff.TabIndex = 7;
            this.cbxLinkServerOnOff.Text = "リンクサーバーコピー";
            this.cbxLinkServerOnOff.UseVisualStyleBackColor = true;
            this.cbxLinkServerOnOff.CheckedChanged += new System.EventHandler(this.CbxLinkServerOnOff_CheckedChanged);
            // 
            // tbxOutputSql
            // 
            this.tbxOutputSql.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxOutputSql.Location = new System.Drawing.Point(147, 233);
            this.tbxOutputSql.Name = "tbxOutputSql";
            this.tbxOutputSql.Size = new System.Drawing.Size(545, 27);
            this.tbxOutputSql.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL出力フォルダ";
            // 
            // btnOutputSql
            // 
            this.btnOutputSql.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOutputSql.Location = new System.Drawing.Point(12, 280);
            this.btnOutputSql.Name = "btnOutputSql";
            this.btnOutputSql.Size = new System.Drawing.Size(107, 40);
            this.btnOutputSql.TabIndex = 9;
            this.btnOutputSql.Text = "出力";
            this.btnOutputSql.UseVisualStyleBackColor = true;
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(695, 233);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(33, 27);
            this.btnSelectOutputFolder.TabIndex = 10;
            this.btnSelectOutputFolder.Text = "・・・";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 330);
            this.Controls.Add(this.btnSelectOutputFolder);
            this.Controls.Add(this.btnOutputSql);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxOutputSql);
            this.Controls.Add(this.gbxSource);
            this.Controls.Add(this.gbxDest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxDest.ResumeLayout(false);
            this.gbxDest.PerformLayout();
            this.gbxSource.ResumeLayout(false);
            this.gbxSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDest;
        private System.Windows.Forms.MaskedTextBox mtbxPasswordDest;
        private System.Windows.Forms.TextBox tbxUserDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDbDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSource;
        private System.Windows.Forms.TextBox tbxLinkServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSchemaSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDbSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxLinkServerOnOff;
        private System.Windows.Forms.TextBox tbxOutputSql;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOutputSql;
        private System.Windows.Forms.Button btnSelectOutputFolder;
    }
}

