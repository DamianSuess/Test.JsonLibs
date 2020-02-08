using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.JsonEngines
{
  [TestClass]
  public class JsonDictStringTests
  {
    [TestMethod]
    public void Utf8DictStringKeyQuickTest()
    {
      // Assign
      var obj1 = new DictStringKey() { StringA = "Helo", IntB = 34 };
      obj1.Add("Item1", "Item1-data");
      obj1.Add("Item2", "Item2-data");

      // Serialize to string
      string json1 = Utf8Json.JsonSerializer.ToJsonString(obj1);

      var obj2 = Utf8Json.JsonSerializer.Deserialize<DictStringKey>(json1);
      string json2 = Utf8Json.JsonSerializer.ToJsonString(obj2);

      Debug.WriteLine($"Utf8 - Before Output:\r\n{json1}");
      Debug.WriteLine($"Utf8 - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void Utf8DictStringKeyFullTest()
    {
      // Utf8Json Usage:
      ////var serialized = Utf8Json.JsonSerializer.Serialize(obj1);
      ////string json1 = Utf8Json.JsonSerializer.ToJsonString<DictStringKey>(obj1);
      ////var obj2 = Utf8Json.JsonSerializer.Deserialize<DictStringKey>(serialized);

      // Assign
      var obj1 = new DictStringKey() { StringA = "Helo", IntB = 34 };
      obj1.Add("Item1", "Item1-data");
      obj1.Add("Item2", "Item2-data");

      // Act
      var serialized = Utf8Json.JsonSerializer.Serialize(obj1);
      Assert.IsNotNull(obj1);

      // Nethod 1 - Serialize to byte[]
      var obj2 = Utf8Json.JsonSerializer.Deserialize<DictStringKey>(serialized);

      // Assert
      Assert.IsNotNull(obj2);
      Assert.AreEqual(obj1.Count, obj2.Count);
      // Assert.AreEqual(obj1.IntB, obj2.IntB);   // Fails - doesn't save StringA or IntB

      // Method 2 - Serialize to string
      string json1 = Utf8Json.JsonSerializer.ToJsonString<DictStringKey>(obj1);
      var obj3 = Utf8Json.JsonSerializer.Deserialize<DictStringKey>(json1);
      string json2 = Utf8Json.JsonSerializer.ToJsonString<DictStringKey>(obj3);

      Debug.WriteLine($"Utf8Full - Before Output:\r\n{json1}");
      Debug.WriteLine($"Utf8Full - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void NewtonsoftDictStringKeyTest()
    {
      // Usage:
      ////var result = Newtonsoft.Json.JsonConvert.SerializeObject(obj1);
      ////var obj2 = Newtonsoft.Json.JsonConvert.DeserializeObject<DictStringKey>(result);

      // Assign
      var obj1 = new DictStringKey() { StringA = "Helo", IntB = 34 };
      obj1.Add("Item1", "Item1-data");
      obj1.Add("Item2", "Item2-data");

      // Serialize to string
      string json1 = Newtonsoft.Json.JsonConvert.SerializeObject(obj1);

      var obj2 = Newtonsoft.Json.JsonConvert.DeserializeObject<DictStringKey>(json1);
      string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(obj2);

      Debug.WriteLine($"Newt - Before Output:\r\n{json1}");
      Debug.WriteLine($"Newt - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void SystemDictStringKeyTest()
    {
      // Usage - System.Text.Json
      ////var serialized = System.Text.Json.JsonSerializer.Serialize(obj1);
      ////var obj2 = System.Text.Json.JsonSerializer.Deserialize<DictStringKey>(serialized);

      // Assign
      var obj1 = new DictStringKey() { StringA = "Helo", IntB = 34 };
      obj1.Add("Item1", "Item1-data");
      obj1.Add("Item2", "Item2-data");

      // Serialize to string
      string json1 = System.Text.Json.JsonSerializer.Serialize(obj1);

      var obj2 = System.Text.Json.JsonSerializer.Deserialize<DictStringKey>(json1);
      string json2 = System.Text.Json.JsonSerializer.Serialize(obj2);

      Debug.WriteLine($"System - Before Output:\r\n{json1}");
      Debug.WriteLine($"System - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }
  }
}