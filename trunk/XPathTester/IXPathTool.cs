using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace XPathTester {
  struct XPathResult {
    public string Result { get; private set; }
    public string Xml { get; private set; }
    public string Path { get; private set; }
    public string[] Tuple { get; private set; }

    public XPathResult(string result, string xml, string path)
      : this() {
      this.Result = result;
      this.Xml = xml;
      this.Path = path;

      this.Tuple = new string[] { result, xml, path };
    }
  }

  interface IXPathTool {
    /// <summary>
    /// Wynik ostatnio wykonanego zapytania
    /// </summary>
    XPathResult[] QueryResults { get; }

    /// <summary>
    /// Wykonuje zapytanie XPath na załadowanym dokumencie
    /// </summary>
    /// <param name="query">Zapytanie XPath</param>
    /// <returns>Kolekcja węzłów wyników zapytania</returns>
    XPathResult[] Query(string query);

    /// <summary>
    /// Pobiera załadowany dokument jako string. Przydatne przy wyświetlaniu
    /// załadowanego dokumentu w richedit
    /// </summary>
    /// <returns>string zawierający cały załadowany dokument</returns>
    string GetDocumentString();

    /// <summary>
    /// Wprowadza zmiany do XMLa
    /// </summary>
    /// <param name="xml">Zmieniony XML</param>
    /// <returns>Wynik wywołania <see cref="Query(string)"/> dla zmienionego
    /// dokumentu</returns>
    XPathResult[] ApplyChanges(string xml);

    /// <summary>
    /// Komunikat błędu zapytania XPath
    /// </summary>
    string Error { get; }
  }
}
