using System.Collections.Generic;
using System.Drawing;
using WinFormsHomework.POCO;
using Xunit;

namespace WinFormsHomeworkTests
{
    public class QuadrilateralTests
    {
        [Fact]
        public void CenterTest()
        {
            var quadrilateral = new Quadrilateral
            {
                Points = new List<Point> { new Point(0, 0), new Point(10, 0), new Point(0, 4), new Point(10, 4) }
            };
            var center = quadrilateral.Center();
            Assert.Equal(5, center.X);
            Assert.Equal(2, center.Y);
        }

        [Fact]
        public void AddPointTest()
        {
            var quadrilateral = new Quadrilateral();
            for (var i = 0; i < 3; i++)
            {
                Assert.Equal(true, quadrilateral.AddPoint(new Point(0, i)));
            }
            Assert.False(quadrilateral.IsCompleted());
            Assert.Equal(false, quadrilateral.AddPoint(new Point(0, 1234)));
            Assert.True(quadrilateral.IsCompleted());
        }
    }
}