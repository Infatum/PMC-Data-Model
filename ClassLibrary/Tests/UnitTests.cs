using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace unitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class TestPositions
    {
        Position<int> positions;
        Point<int> p = new Point<int>(1, 1);
        int MAX_POINTS = 1000;

        [TestFixtureSetUp]
        public void Init()
        {
            positions = new Position<int>();
            p = new Point<int>(10, 10);

            var n = new Random();

            for (int i = 0; i < MAX_POINTS; i++)
            {
                positions.Add(new Point<int>(n.Next(5, 50), n.Next(1, 50)));
            }
        }

        [Test]
        public void TestPoint()
        {
            Assert.NotNull(p);
        }

        [Test]
        public void TestPositionsAddPoint()
        {
            positions.Add(p);
            Assert.True(positions.Contains(p));
        }

        [Test]
        public void TestPositionsRemovePoint()
        {
            positions.Remove(p);
            Assert.False(positions.Contains(p));
        }

        [Test]
        public void TestPositionsCountPoint()
        {
            int curCount = positions.Count;
            positions.Add(new Point<int>(1, 1));

            Assert.AreEqual(curCount, positions.Count - 1);
        }
    }
}
