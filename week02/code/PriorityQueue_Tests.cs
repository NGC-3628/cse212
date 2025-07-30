using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Some people enter with different priority levels. Two fo them has the same level. 5 is the highest priority.
    // Expected Result: Because it is a FIFO Joe enters first, then Sue, and so on. However Tim must be shown first.
    // Defect(s) Found: I changed >= to >. And Added "_queue.RemoveAt(highPriorityIndex);" to remove item. 
    public void TestPriorityQueue_1()
    {
        // Arrange
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5); // Highest priority, first in
        priorityQueue.Enqueue("Sue", 5); // Highest priority, second in
        priorityQueue.Enqueue("Joe", 1);

        // Act
        var result = priorityQueue.Dequeue();

        // Assert
        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario: attempt to dequeue from an empty queue.
    // Expected Result:  throw new InvalidOperationException("The queue is empty.");
    // Defect(s) Found: none xd.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    [TestMethod]
    // Scenario: the item with the highest priority is the last one added to the queue.
    // Expected Result: the last item ("Sue") should be correctly identified and returned.
    // Defect(s) Found: The loop condition `i < count - 1` ignored the last element. This was fixed to `i < count`.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 10); // Highest priority, at the end

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Sue", result);
    }
}