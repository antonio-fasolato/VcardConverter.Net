using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger {
   public enum AppenderLevel {
      none = 0,
      fail = 1,
      grave = 2,
      err = 3,
      info = 4,
      debug = 5,
      trace = 6,
      all = 999
   }
}