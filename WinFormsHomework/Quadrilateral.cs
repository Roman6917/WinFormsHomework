using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WinFormsHomework.POCO
{
	[Serializable]
	public class Quadrilateral
	{
		public const uint SIZE = 4;
		public List<Point> Points { get; set; }
		public int RgbaColor { get; set; }
		public Color Color { get; set; }

		public Quadrilateral()
		{
			Points = new List<Point>();
			Color = Color.Cyan;
		}

		/// <inheritdoc />
		public Quadrilateral(params Point[] points)
		{
			if (points.Length != SIZE)
			{
				throw new ArgumentException($"polygon must contain only {SIZE} points");
			}

			Points = new List<Point>(points);
		}

		public int Count()
		{
			return Points.Count;
		}

		public bool IsCompleted()
		{
			return Points.Count == SIZE && Points.TrueForAll(p => true);
		}

		public bool AddPoint(Point point)
		{
			Points.Add(point);
			return Points.Count != SIZE;
		}

		public Point Center()
		{
			var x = Points.Sum(p => p.X) / (int) SIZE;
			var y = Points.Sum(p => p.Y) / (int) SIZE;
			var point = new Point(x, y);

			return point;
		}


		public Point[] ToArray()
		{
			return Points.ToArray();
		}
	}
}