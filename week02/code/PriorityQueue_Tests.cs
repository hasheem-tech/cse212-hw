using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a a queue with values and their priorities: Apple(20), Mango(15), banana(5), 
    // grapes(29), kiwi(2) and run until the queue is empty.
    // Expected Result: grapes, apple, mango, banana, kiwi
    // Defect(s) Found: Dequeue function wasn't removing the high priority item from the queue
    public void TestPriorityBasedDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("apple", 20);
        priorityQueue.Enqueue("mango", 15);
        priorityQueue.Enqueue("banana", 5);
        priorityQueue.Enqueue("grapes", 29);
        priorityQueue.Enqueue("kiwi", 2);

        string[] expectedResult = ["grapes", "apple", "mango", "banana", "kiwi"];

        for(int i = 0; i < 5; i++)
        {
            string value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }

        
    }

    [TestMethod]
    // Scenario: Create a a queue with values having identical priorities: Apple(20), Mango(20), banana(20), 
    // grapes(20), kiwi(20) and run until the queue is empty.
    // Expected Result: apple, mango, banana, grapes, kiwi
    // Defect(s) Found: there was no code for handling values with identical priorities and removing
    // the one that is more in the front of queue
    public void TestIdenticalPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("apple", 20);
        priorityQueue.Enqueue("mango", 20);
        priorityQueue.Enqueue("banana", 20);
        priorityQueue.Enqueue("grapes", 20);
        priorityQueue.Enqueue("kiwi", 20);

        string[] expectedResult = ["apple", "mango", "banana", "grapes", "kiwi"];

        for(int i = 0; i < 5; i++)
        {
            string value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Scenario: Simply dequeuing an empty queue
    //Expected Result: "The queue is empty." message.
    //Defect(s) found: No error was detected
    public void TestEmptyQueues()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            string value = priorityQueue.Dequeue();
            Assert.Fail("Expected an exception, but none was thrown.");
        }
        catch (InvalidOperationException exception)
        {

            Assert.AreEqual("The queue is empty.", exception.Message);
        }
    }
}