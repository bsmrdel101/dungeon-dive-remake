using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [Test]
    public void TestCase()
    {
        int result = 1 + 1;
        Assert.That(result.Equals(2));
        Assert.AreEqual(4, 2+2);
    }
}
