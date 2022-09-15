namespace MiscPractice.Tests;

[TestClass]
public class LinkedListTests
{
    [TestMethod]
    public void ShouldInsertAtBeginning()
    {
        var linkedList = new Problems.LinkedList<string>();

        Assert.AreEqual(0, linkedList.Count());

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

        Assert.AreEqual(0, linkedList.Count());

        linkedList.InsertAtEnd("test");
        linkedList.InsertAtEnd("nice");
        linkedList.InsertAtEnd("okay");
        linkedList.InsertAtEnd("sweet");
        linkedList.InsertAtEnd("yes");

        Assert.AreEqual(5, linkedList.Count());
        Assert.AreEqual("yes", linkedList.FindNodeByPosition(linkedList.Count() - 1).Data);
    }

    [TestMethod]
    public void ShouldRemove() 
    {

    }
}