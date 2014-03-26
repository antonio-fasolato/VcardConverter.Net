using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Logger {
   public class FileAppender : IAppender {
      private string m_format = "%m";
      private string m_filename = string.Empty;
      private long m_maxFileSizeInBytes = -1;
      private AppenderLevel m_minLevel = AppenderLevel.all;
      private StreamWriter m_fileStream;
      private List<Filter> filters;

      public void configure(XmlNode n) {
         if (n.Attributes["format"] != null) {
            m_format = n.Attributes["format"].Value;
         }
         m_filename = n.Attributes["fileName"].Value;
         if (n.Attributes["maxFileSize"] != null) {
            m_maxFileSizeInBytes = long.Parse(n.Attributes["maxFileSize"].Value);
         }
         if (n.Attributes["level"] != null) {
            m_minLevel = (AppenderLevel)Enum.Parse(typeof(AppenderLevel), n.Attributes["level"].Value);
         }
         filters = new List<Filter>();
      }

      public void addFilter(Filter filter) {
         filters.Add(filter);
      }

      public void append(string message, AppenderLevel level, string className, string programma, string tipoOp) {
         if (level <= m_minLevel) {
            string sout = m_format.Replace("%c", className).Replace("%t", DateTime.Now.ToString()).Replace("%l", level.ToString()).Replace("%m", message).Replace("%p", programma).Replace("%o", tipoOp);
            bool filter = true;
            foreach(Filter f in filters) {
               if(f.test(sout)) {
                  filter = f.include;
               }
            }
            if(filter) {
               logRotate();
               try {
                  if(m_fileStream == null) {
                     m_fileStream = new StreamWriter(m_filename, true);
                  }
                  m_fileStream.WriteLine(sout);
                  m_fileStream.Flush();
               } catch(Exception e) {
                  Console.Error.WriteLine(e.ToString());
               }
            }
         }
      }

      private void logRotate() {
         if (m_maxFileSizeInBytes > 0) {
            FileInfo file = new FileInfo(m_filename);
            if (file.Exists && file.Length > m_maxFileSizeInBytes) {
               try {
                  if (m_fileStream != null) {
                     m_fileStream.Close();
                  }
                  file.MoveTo(m_filename + DateTime.Now.ToString(".yyyyMMdd-hhmmss"));
                  m_fileStream = new StreamWriter(m_filename, true);
               } catch (Exception e) {
                  Console.Error.WriteLine(e.ToString());
               }
            }
         }
      }
   }
}