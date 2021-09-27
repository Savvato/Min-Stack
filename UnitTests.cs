namespace MinStack
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod()
        {
            MinStack stack = new MinStack();

            stack.Push(4);
            stack.Push(6);
            stack.Push(3);
            stack.Push(5);

            Assert.AreEqual(3, stack.GetMin());
            stack.Pop();
            Assert.AreEqual(3, stack.GetMin());
            stack.Pop();
            Assert.AreEqual(4, stack.GetMin());
        }
    }
}
