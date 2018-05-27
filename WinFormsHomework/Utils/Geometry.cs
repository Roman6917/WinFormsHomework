using System.Drawing;


namespace WinFormsHomework.Utils
{
	public static class Geometry
	{
		public static bool IsInPolygon(Point[] polygon, Point point)
		{
			var result = false;
			var j = polygon.Length - 1;
			for (var i = 0; i < polygon.Length; i++)
			{
				if (polygon[i].Y < point.Y && polygon[j].Y >= point.Y || polygon[j].Y < point.Y && polygon[i].Y >= point.Y)
				{
					if (polygon[i].X + (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) <
					    point.X)
					{
						result = !result;
					}
				}

				j = i;
			}

			return result;
		}
	}
}