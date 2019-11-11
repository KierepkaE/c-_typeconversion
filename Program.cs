using System;

namespace TypeConversion {

  class Program {
    byte b = 1;
    int i = b;
    Console.WriteLine (i);
    string number = '1234';
    int i1 = Convert.ToInt32 (number);
    Console.WriteLine (i1);

  }
}