namespace ThreeSumClose.Tests;

[TestClass]
public class ThreeSumClosestTester
{
    private readonly ThreeSumClosest _tester;

    public ThreeSumClosestTester()
    {
        _tester = new ThreeSumClosest();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { -1, 2, 1, -4 };
        int target = 1;

        int result = _tester.ThreeSumClosestFunction(nums, target);

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 0, 0, 0 };
        int target = 1;

        int result = _tester.ThreeSumClosestFunction(nums, target);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 4, 0, 5, -5, 3, 3, 0, -4, -5 };
        int target = -2;

        int result = _tester.ThreeSumClosestFunction(nums, target);

        Assert.AreEqual(-2, result);
    }
}