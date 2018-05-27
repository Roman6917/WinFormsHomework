using System.Drawing;
using System.Linq;

namespace Quadrilateral_Task2.Utils
{
    public static class Geometry
    {
        public static bool IsInPolygon(Point[] polygon, Point point)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < point.Y && polygon[j].Y >= point.Y || polygon[j].Y < point.Y && polygon[i].Y >= point.Y)
                {
                    if (polygon[i].X + (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < point.X)
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
