using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeGameTests

{
    // Test Default Constructor
    [Test]
    public void CubeDefaultConstructorTest()
    {
        Cube defaultCube = new Cube();

        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetVolume());
        Assert.AreEqual(0, defaultCube.GetEdgeLength());
    }

    // Test a 3 x 3 x 3 Cube
    [Test]
    public void CubeThreeByThreeByThreeTest()
    {
        Cube threeByThreeByThree = new Cube(3f, 3f, 3f);

        Assert.AreEqual(3, threeByThreeByThree.GetLength());
        Assert.AreEqual(3, threeByThreeByThree.GetWidth());
        Assert.AreEqual(3, threeByThreeByThree.GetHeight());
        Assert.AreEqual(27, threeByThreeByThree.GetVolume());
        Assert.AreEqual(3, threeByThreeByThree.GetEdgeLength());
    }

    // Test a 10 x 10 x 10 Cube
    [Test]
    public void CubeTenByTenByTenTest()
    {
        Cube tenByTenByTen= new Cube(10f, 10f, 10f);

        Assert.AreEqual(10, tenByTenByTen.GetLength());
        Assert.AreEqual(10, tenByTenByTen.GetWidth());
        Assert.AreEqual(10, tenByTenByTen.GetHeight());
        Assert.AreEqual(1000, tenByTenByTen.GetVolume());
        Assert.AreEqual(10, tenByTenByTen.GetEdgeLength());
    }
}
