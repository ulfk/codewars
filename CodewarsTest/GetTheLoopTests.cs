using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using static Codewars.GetTheLoop;

namespace CodewarsTest
{
    [TestClass]
    public class GetTheLoopTests
    {
        private Node CreateLoop(int tail, int total)
        {
            var node = new Node();
            Node loopStart = null;
            for(var idx = 1; idx < total; idx++)
            {
                var n = new Node();
                if (idx == tail)
                    loopStart = n;
                node.Next = n;
                if (idx < total - 1)
                    node = n;
                else
                    n.Next = loopStart;
            }
            return node;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var loop = CreateLoop(4, 300004);
            var loopLen = GetLoopSize(loop);
            loopLen.Should().Be(300000);
        }
    }
}
