namespace Test;

using System;
using System.Collections.Generic;
using System.Globalization;

public class Test
{
  public long GetLength(string file)
  {
    var stream = new FileStream(file, FileMode.Open);
    return stream.Length;
  }
}