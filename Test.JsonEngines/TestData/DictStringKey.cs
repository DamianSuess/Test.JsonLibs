using System.Collections.Generic;

namespace Test.JsonEngines
{
  public class DictStringKey : Dictionary<string, string>
  {
    public string StringA { get; set; }

    public int IntB { get; set; }
  }
}