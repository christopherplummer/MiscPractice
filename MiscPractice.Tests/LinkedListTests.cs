namespace MiscPractice.Tests;

[TestClass]
public class LinkedListTests
{
    [TestMethod]
    public void ShouldAdd()
    {
        var linkedList = new Problems.LinkedList<string>();

        Assert.AreEqual(0, linkedList.Count());

        linkedList.Add("test");
        linkedList.Add("nice");
        linkedList.Add("okay");
        linkedList.Add("sweet");
        linkedList.Add("yes");

        Assert.AreEqual(5, linkedList.Count());
    }
}