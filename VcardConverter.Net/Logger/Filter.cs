using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Logger {
   public class Filter {
      public bool include { get; set; }
      public string expression { get; set; }
    
      public bool test(string s) {
         return Regex.IsMatch(s, expression);
      }
   }
}
