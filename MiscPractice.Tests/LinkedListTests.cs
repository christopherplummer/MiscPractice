namespace MiscPractice.Tests;

[TestClass]
public class LinkedListTests
{
    [TestMethod]
    public void ShouldInsertAtBeginning()
    {
        var linkedList = new Problems.LinkedList<string>();

        linkedList.InsertAtBeginning("test");
        linkedList.InsertAtBeginning("nice");
        linkedList.InsertAtBeginning("okay");
        linkedList.InsertAtBeginning("sweet");
        linkedList.InsertAtBeginning("yes");

        Assert.AreEqual(5, linkedList.Count());
        Assert.AreEqual("yes", linkedList.Head.Data);
    }

    [TestMethod]
    public void ShouldInsertAtEnd()
    {
        var linkedList = new Problems.LinkedList<string>();

        linkedList.InsertAtEnd("test");
        linkedList.InsertAtEnd("nice");
        linkedList.InsertAtEnd("okay");
        linkedList.InsertAtEnd("sweet");
        linkedList.InsertAtEnd("yes");

        var count = linkedList.Count();
        Assert.AreEqual(5, count);
        Assert.AreEqual("yes", linkedList.FindNodeByPosition(count - 1).Data);
    }

    [TestMethod]
    public void ShouldRemove() 
    {

    }
}