using System;

namespace TypeConversion {

  class Program {
    byte b = 1;
    int i = b;
    Console.WriteLine (i);
    string number = "1234";
    int i1 = Convert.ToInt32 (number);
    Console.WriteLine (i1);

    try {
      var num = "1234";
      byte b1 = Convert.ToByte (num);
      Console.WriteLine (b1);
    } catch (System.Exception) {
      Console.WriteLine ("The number can not be converted to a byte.");
    }

    try {
      string str = "true";
      bool bo = Convert.ToBoolean (str);
      Console.WriteLine (bo);
    } catch (System.Exception) {
      Console.WriteLine ("The string can not be converted to a boolean.");
    }

  }
}