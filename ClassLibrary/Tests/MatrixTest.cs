using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTest
    {
        Matrix<double> matrix;
        Position<double> pos;
        Point<double> p;
        int MAX_POINTS = 100;
        int MAX_POSITIONS = 500;


        [TestFixtureSetUp]
        public void Init()
        {
            matrix = new Matrix<double>();
            p = new Point<double>(10d, 10d);
            pos = new Position<double>();

            var n = new Random();

            for (int i = 0; i < MAX_POINTS; i++)
            {
                for (int j = 0; j < MAX_POSITIONS; j++)
                {
                    pos.Add(new Point<double>(n.NextDouble(), n.NextDouble()));
                }
                matrix.Add(pos);
            }
        }

        [Test]
        public void TestMatrix()
        {
            Assert.NotNull(pos);
            Assert.NotNull(matrix);
        }

        [Test]
        public void TestMatrixAdd()
        {
            pos.Add(p);
            matrix.Add(pos);
            Assert.True(pos.Contains(p));
            Assert.True(matrix.Contains(pos));

        }

        [Test]
        public void TestMatrixRemove()
        {
            Point<double> p2 = new Point<double>(2d, 3d);
            Position<double> pos2 = new Position<double>();
            pos2.Add(p2);
            matrix.Add(pos2);
            Assert.False(matrix.Contains(pos2));
        }

        [Test]
        public void TestPositionsCountPoint()
        {
            int curCount = pos.Count;
            pos.Add(new Point<double>(1d, 1d));

            Assert.AreEqual(curCount, pos.Count - 1);

            int curMatrixCount = matrix.Count;
            matrix.Add(new Position<double>());

            Assert.AreEqual(curMatrixCount, matrix.Count - 1);
        }
    }
}

