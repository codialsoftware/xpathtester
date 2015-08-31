using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace XPathTester
{
    public partial class Form1 : Form
    {
        private IXPathTool xpathTool;

        public Form1()
        {
            InitializeComponent();

            xpathQuery.Clear();
            xpathResults.Items.Clear();
            xmlView.Text = string.Empty;
            xpathError.Text = string.Empty;

            RegisterDebug();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            var result = openXML.ShowDialog();

            if (result == DialogResult.OK)
            {
                createTool();
                showXml();
            }
        }

        private void showXml()
        {
            xmlView.TextChanged -= xmlView_TextChanged;
            xmlView.Clear();

            if (xpathTool != null)
            {
                xmlView.Text = xpathTool.GetDocumentString();
                xmlView.TextChanged += xmlView_TextChanged;
            }
        }

        private void createTool()
        {
            xpathTool = ToolsFactory.Create(openXML.FileName, xmlView.Text);
        }

        private void xmlView_TextChanged(object sender, EventArgs e)
        {
            if (xpathTool == null)
            {
                createTool();
            }

            if (xpathTool != null)
            {
                xpathTool.ApplyChanges(xmlView.Text);
                RefreshResultsView();
            }
        }

        private void xpathQuery_TextChanged(object sender, EventArgs e)
        {
            if (xpathTool == null)
            {
                createTool();
            }

            if (xpathTool != null)
            {
                xpathTool.Query(xpathQuery.Text);
                RefreshResultsView();
            }
        }

        private void RefreshResultsView()
        {
            xpathResults.Items.Clear();
            xpathError.Text = xpathTool.Error;
            if (xpathTool.QueryResults == null)
                return;

            xpathResults.SuspendLayout();
            {
// klamra tylko po to, by zaznaczyć suspendlayout i resumelayout
                foreach (var r in xpathTool.QueryResults)
                {
                    xpathResults.Items.Add(new ListViewItem(r.Tuple));
                }
            }
            xpathResults.ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xpathTool == null)
            {
                createTool();
            }

            RefreshResultsView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xpathTool = ToolsFactory.Create(@"e:\prog\Stock\XPathTester_PROJECT\XPathTester\sample.html", string.Empty);
            showXml();
            xpathQuery.Text = @"//*[@name='_searchCategory']";
        }

        [Conditional("DEBUG")]
        private void RegisterDebug()
        {
            var b = new Button();
            b.AutoSize = true;
            b.Location = openFile.Location;
            b.Text = "Debug refresh";
            b.Click += button1_Click;
            Controls.Add(b);

            Load += Form1_Load;
        }
    }
}