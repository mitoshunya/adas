namespace PythonCall
{
    partial class MainWindow
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
            this.uxPythonSource = new System.Windows.Forms.TextBox();
            this.uxResult = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uxExec = new System.Windows.Forms.Button();
            this.uxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxMesssage = new System.Windows.Forms.TextBox();
            this.uxCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPythonSource
            // 
            this.uxPythonSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPythonSource.Location = new System.Drawing.Point(0, 0);
            this.uxPythonSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxPythonSource.Multiline = true;
            this.uxPythonSource.Name = "uxPythonSource";
            this.uxPythonSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxPythonSource.Size = new System.Drawing.Size(336, 349);
            this.uxPythonSource.TabIndex = 0;
            // 
            // uxResult
            // 
            this.uxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxResult.Location = new System.Drawing.Point(0, 0);
            this.uxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxResult.Multiline = true;
            this.uxResult.Name = "uxResult";
            this.uxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxResult.Size = new System.Drawing.Size(320, 349);
            this.uxResult.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 62);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uxPythonSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxResult);
            this.splitContainer1.Size = new System.Drawing.Size(661, 349);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // uxExec
            // 
            this.uxExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxExec.Location = new System.Drawing.Point(562, 4);
            this.uxExec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxExec.Name = "uxExec";
            this.uxExec.Size = new System.Drawing.Size(87, 51);
            this.uxExec.TabIndex = 2;
            this.uxExec.Text = "実行";
            this.uxExec.UseVisualStyleBackColor = true;
            this.uxExec.Click += new System.EventHandler(this.uxExec_Click);
            // 
            // uxPath
            // 
            this.uxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPath.Location = new System.Drawing.Point(169, 4);
            this.uxPath.Name = "uxPath";
            this.uxPath.Size = new System.Drawing.Size(377, 23);
            this.uxPath.TabIndex = 3;
            this.uxPath.Text = ".\\python.pi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Python プログラム出力先パス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "任意の文字列";
            // 
            // uxMesssage
            // 
            this.uxMesssage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMesssage.Location = new System.Drawing.Point(169, 32);
            this.uxMesssage.Name = "uxMesssage";
            this.uxMesssage.Size = new System.Drawing.Size(209, 23);
            this.uxMesssage.TabIndex = 6;
            this.uxMesssage.Text = "Pythonテスト";
            // 
            // uxCount
            // 
            this.uxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCount.Location = new System.Drawing.Point(438, 32);
            this.uxCount.Name = "uxCount";
            this.uxCount.Size = new System.Drawing.Size(108, 23);
            this.uxCount.TabIndex = 7;
            this.uxCount.Text = "1000";
            this.uxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ループ数";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxCount);
            this.Controls.Add(this.uxMesssage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPath);
            this.Controls.Add(this.uxExec);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxPythonSource;
        private System.Windows.Forms.TextBox uxResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button uxExec;
        private System.Windows.Forms.TextBox uxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxMesssage;
        private System.Windows.Forms.TextBox uxCount;
        private System.Windows.Forms.Label label3;
    }
}

