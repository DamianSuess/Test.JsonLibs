using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.JsonEngines
{
  [TestClass]
  public class JsonDictIntTests
  {
    [TestMethod]
    public void Utf8DictIntKeySimpleTest()
    {
      // Assign
      var obj1 = new Dictionary<int, string>();
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Serialize to string
      string json1 = Utf8Json.JsonSerializer.ToJsonString(obj1);

      var obj2 = Utf8Json.JsonSerializer.Deserialize<Dictionary<int, string>>(json1);
      string json2 = Utf8Json.JsonSerializer.ToJsonString(obj2);

      Debug.WriteLine($"Utf8 - Before Output:\r\n{json1}");
      Debug.WriteLine($"Utf8 - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void Utf8DictIntKeyTesting()
    {
      /*
      This is caused by the wrong formatter was chosen.
      It should choose GenericDictionaryFormatter but choose NonGenericDictionaryFormatter.

      Thanks, this is a bug, I should fix it.

      Workaround, you can register manually.

      Utf8Json.Resolvers.CompositeResolver.RegisterAndSetAsDefault(
        new[] { new Utf8Json.Formatters.GenericDictionaryFormatter<Key, string, TestKey>() },
        new[] { Utf8Json.Resolvers.StandardResolver.Default });
       */
    }

    [TestMethod]
    public void Utf8DictIntKeyQuickTest()
    {
      // Assign
      var obj1 = new DictIntKey(); //  { StringA = "Helo", IntB = 34 };
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Object to string
      string json1 = Utf8Json.JsonSerializer.ToJsonString(obj1);
      Debug.WriteLine($"Utf8 - Before Output:\r\n{json1}");

      // String to object
      var obj2 = Utf8Json.JsonSerializer.Deserialize<DictIntKey>(json1);
      string json2 = Utf8Json.JsonSerializer.ToJsonString(obj2);

      Debug.WriteLine($"Utf8 - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void Utf8DictIntKeyFullTest()
    {
      // Utf8Json Usage:
      ////var serialized = Utf8Json.JsonSerializer.Serialize(obj1);
      ////string json1 = Utf8Json.JsonSerializer.ToJsonString<DictIntKey>(obj1);
      ////var obj2 = Utf8Json.JsonSerializer.Deserialize<DictIntKey>(serialized);

      // Assign
      var obj1 = new DictIntKey(); // { StringA = "Helo", IntB = 34 };
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Act
      var serialized = Utf8Json.JsonSerializer.Serialize(obj1);
      Assert.IsNotNull(obj1);

      // Nethod 1 - Serialize to byte[]
      var obj2 = Utf8Json.JsonSerializer.Deserialize<DictIntKey>(serialized);

      // Assert
      Assert.IsNotNull(obj2);
      Assert.AreEqual(obj1.Count, obj2.Count);
      // Assert.AreEqual(obj1.IntB, obj2.IntB);   // Fails - doesn't save StringA or IntB

      // Method 2 - Serialize to string
      string json1 = Utf8Json.JsonSerializer.ToJsonString<DictIntKey>(obj1);
      var obj3 = Utf8Json.JsonSerializer.Deserialize<DictIntKey>(json1);
      string json2 = Utf8Json.JsonSerializer.ToJsonString<DictIntKey>(obj3);

      Debug.WriteLine($"Utf8Full - Before Output:\r\n{json1}");
      Debug.WriteLine($"Utf8Full - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void NewtonsoftDictIntKeyTest()
    {
      // Usage:
      ////var result = Newtonsoft.Json.JsonConvert.SerializeObject(obj1);
      ////var obj2 = Newtonsoft.Json.JsonConvert.DeserializeObject<DictIntKey>(result);

      // Assign
      var obj1 = new DictIntKey(); // { StringA = "Helo", IntB = 34 };
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Serialize to string
      string json1 = Newtonsoft.Json.JsonConvert.SerializeObject(obj1);

      var obj2 = Newtonsoft.Json.JsonConvert.DeserializeObject<DictIntKey>(json1);
      string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(obj2);

      Debug.WriteLine($"Newt - Before Output:\r\n{json1}");
      Debug.WriteLine($"Newt - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void SystemDictIntKeyTest()
    {
      // Usage - System.Text.Json
      ////var serialized = System.Text.Json.JsonSerializer.Serialize(obj1);
      ////var obj2 = System.Text.Json.JsonSerializer.Deserialize<DictIntKey>(serialized);

      // Assign
      var obj1 = new DictIntKey(); // { StringA = "Helo", IntB = 34 };
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Serialize to string
      string json1 = System.Text.Json.JsonSerializer.Serialize(obj1);

      var obj2 = System.Text.Json.JsonSerializer.Deserialize<DictIntKey>(json1);
      string json2 = System.Text.Json.JsonSerializer.Serialize(obj2);

      Debug.WriteLine($"System - Before Output:\r\n{json1}");
      Debug.WriteLine($"System - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }

    [TestMethod]
    public void SystemDictIntKeySimpleTest()
    {
      // Usage - System.Text.Json
      ////var serialized = System.Text.Json.JsonSerializer.Serialize(obj1);
      ////var obj2 = System.Text.Json.JsonSerializer.Deserialize<DictIntKey>(serialized);

      // Assign
      var obj1 = new Dictionary<int, string>(); // { StringA = "Helo", IntB = 34 };
      obj1.Add(1, "Item1-data");
      obj1.Add(2, "Item2-data");

      // Serialize to string
      string json1 = System.Text.Json.JsonSerializer.Serialize(obj1);

      var obj2 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<int, string>>(json1);
      string json2 = System.Text.Json.JsonSerializer.Serialize(obj2);

      Debug.WriteLine($"System - Before Output:\r\n{json1}");
      Debug.WriteLine($"System - After Output:\r\n{json2}");

      Assert.AreEqual(json1, json2);
    }
  }
}