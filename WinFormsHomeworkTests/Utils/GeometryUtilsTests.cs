using System.Drawing;
using WinFormsHomework.Utils;
using Xunit;

namespace WinFormsHomeworkTests.Utils
{
	public class GeometryUtilsTests
	{
		[Fact]
		public void IsInPolygonTest()
		{
			var points = new[]
			{
				new Point(0, 0),
				new Point(10, 0),
				new Point(99, 97),
				new Point(0, 10)
			};
			var point = new Point(5, 7);

			Assert.Equal(true, Geometry.IsInPolygon(points, point));

			point = new Point(-1, 2);

			Assert.Equal(false, Geometry.IsInPolygon(points, point));
		}
	}
}