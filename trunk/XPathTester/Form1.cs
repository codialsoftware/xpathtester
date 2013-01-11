using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Diagnostics;

namespace XPathTester {
  public partial class Form1 : Form {
    IXPathTool xpathTool;

    public Form1() {
      InitializeComponent();

      this.xpathQuery.Clear();
      this.xpathResults.Items.Clear();
      this.xmlView.Text = string.Empty;
      this.xpathError.Text = string.Empty;

      RegisterDebug();
    }

    private void openFile_Click(object sender, EventArgs e) {
      DialogResult result = this.openXML.ShowDialog();

      if (result == System.Windows.Forms.DialogResult.OK) {
        createTool();
        showXml();
      }
    }

    private void showXml() {
      this.xmlView.TextChanged -= xmlView_TextChanged;
      this.xmlView.Clear();

      if (this.xpathTool != null) {
        this.xmlView.Text = this.xpathTool.GetDocumentString();
        this.xmlView.TextChanged += xmlView_TextChanged;
      }
    }

    private void createTool() {
      this.xpathTool = ToolsFactory.Create(this.openXML.FileName, this.xmlView.Text);
    }

    private void xmlView_TextChanged(object sender, EventArgs e) {
      if (this.xpathTool == null) {
        createTool();
      }

      if (this.xpathTool != null) {
        this.xpathTool.ApplyChanges(this.xmlView.Text);
        RefreshResultsView();
      }
    }

    private void xpathQuery_TextChanged(object sender, EventArgs e) {
      if (this.xpathTool == null) {
        createTool();
      }

      if (this.xpathTool != null) {
        this.xpathTool.Query(this.xpathQuery.Text);
        RefreshResultsView();
      }
    }

    private void RefreshResultsView() {
      this.xpathResults.Items.Clear();
      this.xpathError.Text = this.xpathTool.Error;
      if (this.xpathTool.QueryResults == null)
        return;

      this.xpathResults.SuspendLayout();
      {// klamra tylko po to, by zaznaczyć suspendlayout i resumelayout
        foreach (XPathResult r in this.xpathTool.QueryResults) {
          this.xpathResults.Items.Add(new ListViewItem(r.Tuple));
        }
      }
      this.xpathResults.ResumeLayout();
    }


    private void button1_Click(object sender, EventArgs e) {
      if (this.xpathTool == null) {
        createTool();
      }

      RefreshResultsView();
    }

    private void Form1_Load(object sender, EventArgs e) {
      this.xpathTool = ToolsFactory.Create(@"e:\prog\Stock\XPathTester_PROJECT\XPathTester\sample.html", string.Empty);
      showXml();
      this.xpathQuery.Text = @"//*[@name='_searchCategory']";
    }

    [Conditional("DEBUG")]
    private void RegisterDebug() {
      Button b = new Button();
      b.AutoSize = true;
      b.Location = this.openFile.Location;
      b.Text = "Debug refresh";
      b.Click += button1_Click;
      this.Controls.Add(b);

      this.Load += Form1_Load;
    }
  }
}
