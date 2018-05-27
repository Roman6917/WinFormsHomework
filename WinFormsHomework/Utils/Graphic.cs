using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsHomework.POCO;

namespace WinFormsHomework.Utils
{
	public static class Graphic
	{
		private const int POINT_SIZE = 4;

		public static void Redraw(Panel panel, Graphics graphics, List<Quadrilateral> quadrilaterals)
		{
			panel.Refresh();
			foreach (var item in quadrilaterals)
			{
				DrawPolygon(graphics, item);
			}
		}

		private static void DrawPolygon(Graphics graphics, Quadrilateral quadrilateral)
		{
			graphics.FillPolygon(new SolidBrush(quadrilateral.Color), quadrilateral.ToArray());
		}

		private static void DrawPoint(Graphics graphics, Point point)
		{
			graphics.FillRectangle(Brushes.Black, point.X, point.Y, POINT_SIZE, POINT_SIZE);
		}
	}
}