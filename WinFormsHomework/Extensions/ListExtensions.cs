using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using WinFormsHomework.POCO;
using WinFormsHomework.Utils;

namespace WinFormsHomework.Extensions
{
	public static class ListExtensions
	{
		public static Quadrilateral RemoveAndGet(this IList<Quadrilateral> list, Point point)
		{
			lock (list)
			{
				var index = 0;
				var isFound = false;
				for (; index < list.Count; index++)
				{
					if (Geometry.IsInPolygon(list.ElementAt(index).ToArray(), point) != true) continue;
					isFound = true;
					break;
				}

				if (!isFound) return null;
				var result = list.ElementAt(index);
				list.RemoveAt(index);

				return result;
			}
		}
	}
}