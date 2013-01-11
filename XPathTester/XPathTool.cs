using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.IO;

namespace XPathTester {
  class HtmlDoc : IXPathTool {
    HtmlDocument document;

    string lastQuery;
    string errorMsg;

    public XPathResult[] QueryResults { get; private set; }

    public HtmlDoc(string path) {
      this.document = new HtmlDocument();
      if (IsPath(path)) {
        this.document.Load(path);
      }
      else {
        this.document.LoadHtml(path);
      }

      if (this.document.DocumentNode == null) {
        throw new ArgumentException("Couldn't parse document", "path");
      }
    }

    public XPathResult[] Query(string query) {
      this.lastQuery = query;
      return Query();
    }

    public string GetDocumentString() {
      return this.document.DocumentNode.OuterHtml;
    }

    public XPathResult[] ApplyChanges(string xml) {
      this.document.LoadHtml(xml);
      return Query();
    }

    public string Error {
      get {
        return this.errorMsg;
      }
    }

    private XPathResult[] Query() {
      runQuery();
      return this.QueryResults;
    }

    private void runQuery() {
      this.QueryResults = null;
      try {
        HtmlNodeCollection nodes = this.document.DocumentNode.SelectNodes(this.lastQuery);
        if (nodes == null) {
          return;
        }

        // Budowanie wyniku
        List<XPathResult> results = new List<XPathResult>();
        foreach (HtmlNode node in nodes) {
          results.Add(new XPathResult(node.Name, node.OuterHtml, node.XPath));
        }

        this.errorMsg = "OK";
        this.QueryResults = results.ToArray();
      }
//      catch (NullReferenceException e) {
//        this.errorMsg = e.Message;
//      }
      catch (Exception e) {
        this.errorMsg = e.Message;
      }
    }

    private bool IsPath(string f) {
      // sprawdzamy, czy to jest plik lokalny
      try {
        return Path.GetFullPath(f) != null;
      }
      catch {
        // nie jest
      }

      try {
        return Uri.IsWellFormedUriString(f, UriKind.RelativeOrAbsolute);
      }
      catch {
      }

      return false;
    }
  }
}
