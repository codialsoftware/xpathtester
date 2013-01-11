namespace XPathTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("asdfasdfsdfsdfs");
          System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("sdfsdfsdfsdfsdf");
          System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("fdfdfdfdfdf");
          this.splitContainer1 = new System.Windows.Forms.SplitContainer();
          this.openFile = new System.Windows.Forms.Button();
          this.xmlView = new System.Windows.Forms.RichTextBox();
          this.splitContainer2 = new System.Windows.Forms.SplitContainer();
          this.xpathResults = new System.Windows.Forms.ListView();
          this.xpathQuery = new System.Windows.Forms.TextBox();
          this.xpathError = new System.Windows.Forms.Label();
          this.openXML = new System.Windows.Forms.OpenFileDialog();
          this.clTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
          this.clXml = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
          this.clPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
          ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
          this.splitContainer1.Panel1.SuspendLayout();
          this.splitContainer1.Panel2.SuspendLayout();
          this.splitContainer1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
          this.splitContainer2.Panel1.SuspendLayout();
          this.splitContainer2.Panel2.SuspendLayout();
          this.splitContainer2.SuspendLayout();
          this.SuspendLayout();
          // 
          // splitContainer1
          // 
          this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer1.Location = new System.Drawing.Point(0, 0);
          this.splitContainer1.Name = "splitContainer1";
          // 
          // splitContainer1.Panel1
          // 
          this.splitContainer1.Panel1.Controls.Add(this.openFile);
          this.splitContainer1.Panel1.Controls.Add(this.xmlView);
          // 
          // splitContainer1.Panel2
          // 
          this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
          this.splitContainer1.Size = new System.Drawing.Size(733, 482);
          this.splitContainer1.SplitterDistance = 244;
          this.splitContainer1.SplitterWidth = 10;
          this.splitContainer1.TabIndex = 0;
          // 
          // openFile
          // 
          this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.openFile.Location = new System.Drawing.Point(3, 3);
          this.openFile.Name = "openFile";
          this.openFile.Size = new System.Drawing.Size(238, 23);
          this.openFile.TabIndex = 1;
          this.openFile.Text = "Open XML";
          this.openFile.UseVisualStyleBackColor = true;
          this.openFile.Click += new System.EventHandler(this.openFile_Click);
          // 
          // xmlView
          // 
          this.xmlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.xmlView.Location = new System.Drawing.Point(3, 29);
          this.xmlView.Name = "xmlView";
          this.xmlView.Size = new System.Drawing.Size(238, 450);
          this.xmlView.TabIndex = 0;
          this.xmlView.Text = "";
          // 
          // splitContainer2
          // 
          this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
          this.splitContainer2.Location = new System.Drawing.Point(0, 0);
          this.splitContainer2.Name = "splitContainer2";
          this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
          // 
          // splitContainer2.Panel1
          // 
          this.splitContainer2.Panel1.Controls.Add(this.xpathResults);
          this.splitContainer2.Panel1.Controls.Add(this.xpathQuery);
          // 
          // splitContainer2.Panel2
          // 
          this.splitContainer2.Panel2.Controls.Add(this.xpathError);
          this.splitContainer2.Size = new System.Drawing.Size(479, 482);
          this.splitContainer2.SplitterDistance = 444;
          this.splitContainer2.SplitterWidth = 10;
          this.splitContainer2.TabIndex = 2;
          // 
          // xpathResults
          // 
          this.xpathResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.xpathResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTag,
            this.clXml,
            this.clPath});
          this.xpathResults.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
          this.xpathResults.FullRowSelect = true;
          this.xpathResults.GridLines = true;
          this.xpathResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
          this.xpathResults.HideSelection = false;
          listViewItem7.StateImageIndex = 0;
          listViewItem8.StateImageIndex = 0;
          listViewItem9.StateImageIndex = 0;
          this.xpathResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
          this.xpathResults.Location = new System.Drawing.Point(3, 29);
          this.xpathResults.Name = "xpathResults";
          this.xpathResults.Size = new System.Drawing.Size(473, 412);
          this.xpathResults.TabIndex = 1;
          this.xpathResults.UseCompatibleStateImageBehavior = false;
          this.xpathResults.View = System.Windows.Forms.View.Details;
          // 
          // xpathQuery
          // 
          this.xpathQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.xpathQuery.Location = new System.Drawing.Point(3, 3);
          this.xpathQuery.Name = "xpathQuery";
          this.xpathQuery.Size = new System.Drawing.Size(473, 20);
          this.xpathQuery.TabIndex = 0;
          this.xpathQuery.TextChanged += new System.EventHandler(this.xpathQuery_TextChanged);
          // 
          // xpathError
          // 
          this.xpathError.Dock = System.Windows.Forms.DockStyle.Fill;
          this.xpathError.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.xpathError.Location = new System.Drawing.Point(0, 0);
          this.xpathError.Name = "xpathError";
          this.xpathError.Size = new System.Drawing.Size(479, 28);
          this.xpathError.TabIndex = 0;
          this.xpathError.Text = "label1";
          // 
          // openXML
          // 
          this.openXML.DefaultExt = "xml";
          // 
          // clTag
          // 
          this.clTag.Text = "Tag";
          // 
          // clXml
          // 
          this.clXml.Text = "String";
          // 
          // clPath
          // 
          this.clPath.Text = "Path";
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(733, 482);
          this.Controls.Add(this.splitContainer1);
          this.Name = "Form1";
          this.Text = "Form1";
          this.splitContainer1.Panel1.ResumeLayout(false);
          this.splitContainer1.Panel2.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
          this.splitContainer1.ResumeLayout(false);
          this.splitContainer2.Panel1.ResumeLayout(false);
          this.splitContainer2.Panel1.PerformLayout();
          this.splitContainer2.Panel2.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
          this.splitContainer2.ResumeLayout(false);
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.RichTextBox xmlView;
        private System.Windows.Forms.TextBox xpathQuery;
        private System.Windows.Forms.OpenFileDialog openXML;
        private System.Windows.Forms.ListView xpathResults;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label xpathError;
        private System.Windows.Forms.ColumnHeader clTag;
        private System.Windows.Forms.ColumnHeader clXml;
        private System.Windows.Forms.ColumnHeader clPath;
    }
}

