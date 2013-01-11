using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace XPathTester {
  class ToolsFactory {
    static Type[] objects = new Type[] {
            typeof(HtmlDoc)
        };

    public static IXPathTool Create(string path, string xml) {
      if (string.IsNullOrWhiteSpace(path)) {
        path = xml;
      }
      if (!string.IsNullOrWhiteSpace(path)) {
        foreach (Type t in objects) {
          try {
            ConstructorInfo cstr = t.GetConstructor(new Type[] { typeof(string) });
            if (cstr != null) {
              return (IXPathTool)cstr.Invoke(new object[] { path });
            }
          }
          catch {
            // nic nie robimy, po prostu nie udało się stworzyć obiektu
            // więc próbujemy z następnym dziadem
          }
        }
      }

      return null;
    }
  }
}
