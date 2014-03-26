using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Logger {
   public class Logger {
      private static List<IAppender> m_appenders;
      private static AppenderLevel m_minLevel = AppenderLevel.debug;
      private static DateTime m_configDate;

      private static void loadConfiguration() {
         String fileName = System.AppDomain.CurrentDomain.BaseDirectory + "logger-conf.xml";

         FileInfo configFile = new FileInfo(fileName);
         if (configFile.Exists) {
            if (configFile.LastWriteTime != m_configDate) {
               m_appenders = new List<IAppender>();

               try {
                  XmlDocument doc = new XmlDocument();
                  doc.Load(configFile.FullName);
                  XmlNode logger = doc.GetElementsByTagName("logger")[0];
                  if (logger.Attributes["level"] != null) {
                     m_minLevel = (AppenderLevel)Enum.Parse(typeof(AppenderLevel), logger.Attributes["level"].Value);
                  }

                  XmlNodeList nodes = doc.GetElementsByTagName("appender");
                  foreach (XmlNode n in nodes) {
                     string appenderType = n.Attributes["type"].Value;
                     string format = n.Attributes["format"].Value;
                     if (format == null) {
                        format = "%m";
                     }
                     switch (appenderType) {
                        case "console":
                           break;
                        case "visualStudio":
                           break;
                        case "file":
                           FileAppender fAppender = new FileAppender();
                           fAppender.configure(n);
                           //Filtri
                           if(n.HasChildNodes) {
                              foreach(XmlNode fn in n.ChildNodes) {
                                 if(fn.Name == "filter") {
                                    Filter filter = new Filter();
                                    filter.include = fn.Attributes["include"].Value == "1";
                                    filter.expression = fn.Attributes["expression"].Value;
                                    fAppender.addFilter(filter);
                                 }
                              }
                           }
                           m_appenders.Add(fAppender);
                           break;
                        case "mail":
                           break;
                     }
                  }

                  m_configDate = configFile.LastWriteTime;
               } catch (Exception e) {
                  throw new Exception("Errore nel caricamento del file di configurazione", e);
               }
            }
         }
      }

      private static void log(object o, AppenderLevel level, string programma, string tipoOp) {
         loadConfiguration();

         StackTrace st = new StackTrace();
         string className = st.GetFrame(2).GetMethod().DeclaringType.ToString();
         if (level <= m_minLevel) {
            foreach (IAppender appender in m_appenders) {
               appender.append(o == null ? "NULL" : o.ToString(), level, className, programma, tipoOp);
            }
         }
      }

      public static void debug(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.debug, programma, tipoOp);
      }
      public static void err(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.err, programma, tipoOp);
      }
      public static void fail(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.fail, programma, tipoOp);
      }
      public static void grave(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.grave, programma, tipoOp);
      }
      public static void info(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.info, programma, tipoOp);
      }
      public static void trace(object message, string programma, string tipoOp) {
         log(message, AppenderLevel.trace, programma, tipoOp);
      }
   }
}