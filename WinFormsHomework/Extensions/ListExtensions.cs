using Quadrilateral_Task2.POCO;
using Quadrilateral_Task2.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Quadrilateral_Task2.Extensions
{
    public static class ListExtensions
    {
        public static Quadrilateral RemoveAndGet(this IList<Quadrilateral> list, Point point)
        {
            lock (list)
            {
                Quadrilateral result = null;
                int index = 0;
                bool isFound = false;
                for (; index < list.Count(); index++)
                {
                    if (Geometry.IsInPolygon(list.ElementAt(index).ToArray(), point) == true)
                    {
                        isFound = true;
                        break;
                    }
                }

                if(isFound)
                {
                    result = list.ElementAt(index);
                    list.RemoveAt(index);
                }

                return result;
            }
        }
    }
}
