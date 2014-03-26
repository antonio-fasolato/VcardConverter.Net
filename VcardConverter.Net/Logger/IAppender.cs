using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Logger {
   public interface IAppender {
      void configure(XmlNode n);
      void addFilter(Filter f);
      void append(string message, AppenderLevel level, string className, string programma, string tipoOp);
   }
}