/* Copyright Xeno Innovations, Inc. 2020
 * Date:    2020-3-10
 * Author:  Damian Suess
 * File:    BenchmarkTests.cs
 * Description:
 *
 */

using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.JsonEngines
{
  /// https://benchmarkdotnet.org/articles/overview.html
  public class HashComparison
  {
    public readonly byte[] _data;
    private const int Size = 1000;
    private readonly SHA256 _sha256 = SHA256.Create();
    private readonly MD5 _md5 = MD5.Create();

    public HashComparison()
    {
      _data = new byte[Size];
      new Random(42).NextBytes(_data);
    }

    [Benchmark]
    public byte[] Sha256() => _sha256.ComputeHash(_data);

    [Benchmark]
    public byte[] Md5() => _md5.ComputeHash(_data);
  }

  [TestClass]
  public class BenchmarkTests
  {
    [TestMethod]
    public void ComparisonTest()
    {
      var summary = BenchmarkRunner.Run(typeof(BenchmarkTests).Assembly);

      summary
    }
  }
}