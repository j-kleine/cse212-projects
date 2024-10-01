using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try to dequeue next item from empty priority queue
    // Expected Result: Exception should be thrown with appropriate error message
    // Defect(s) Found: --
    public void TestPriorityQueue_1_Empty() //Throw Exception when queue empty
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Create a queue with the following item and priority: A (1), enqueue and dequeue it
    // Expected Result: Item is enqueued and then dequeued without an error
    // Defect(s) Found: --
    public void TestPriorityQueue_2_GeneralEnqueueDequeue() //General Enqueue/Dequeue Test with one item
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
    
        var result = priorityQueue.Dequeue();
    
        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: A (1), B (3), C (2)
    // Expected Result: Dequeue item with highest priority first => B
    // Defect(s) Found: --
    public void TestPriorityQueue_3_DifferentPrio() //Enqueue multiple items with different priorities
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();
        
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priorities: A (2), B (2), C (1)
    // Expected Result: Dequeue item with highest priority first, if multiple with same priority, item closest to front is handled first => A
    // Defect(s) Found: loop range skips last element in queue when looking for highest priority item ("_queue.Count - 1")
    public void TestPriorityQueue_4_SamePrio() //Enqueue multiple items with the same priority
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 1);
        
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }
}