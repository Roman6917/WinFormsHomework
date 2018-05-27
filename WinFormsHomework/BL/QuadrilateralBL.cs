using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using WinFormsHomework.POCO;
using WinFormsHomework.Utils;
using static WinFormsHomework.BL.QuadrilateralBl;

namespace WinFormsHomework.BL
{
	public static class QuadrilateralBl
	{
		public static IEnumerable<string> LoadFiguresList()
		{
			List<string> files = null;
			var path = IOUtils.GetDataDirectoryPath();
			if (Directory.Exists(path))
			{
				files = new List<string>(Directory.GetFiles(path).Where(p => Path.GetExtension(p) == ".xml")
					.Select(Path.GetFileName));
			}

			return files;
		}

		public static IEnumerable<Quadrilateral> LoadFigures(string fileName)
		{
			var path = IOUtils.GetDataDirectoryPath() + "\\" + fileName;
			if (!File.Exists(path))
			{
				throw new IOException($"can not find file : {path}");
			}

			var quadrilaterals = DeserializeList(path);

			return quadrilaterals;
		}

		public static void SerializeList(List<Quadrilateral> quadrilaterals, string path)
		{
			var formatter = new XmlSerializer(typeof(List<Quadrilateral>));
			quadrilaterals.ForEach(p => p.RgbaColor = p.Color.ToArgb());
			using (var fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, quadrilaterals);
			}
		}

		public static List<Quadrilateral> DeserializeList(string path)
		{
			var formatter = new XmlSerializer(typeof(List<Quadrilateral>));
			List<Quadrilateral> quadrilaterals;
			using (var fs = new FileStream(path, FileMode.Open))
			{
				quadrilaterals = (List<Quadrilateral>) formatter.Deserialize(fs);
			}

			if (quadrilaterals == null)
			{
				throw new ApplicationException($"cannot deserialize file {path}");
			}

			quadrilaterals.ForEach(p => p.Color = Color.FromArgb(p.RgbaColor));

			return quadrilaterals;
		}

		public static Quadrilateral MoveToPoint(Quadrilateral quadrilateral, Point newCenter)
		{
			var previouseCenter = quadrilateral.Center();
			var xShifting = previouseCenter.X - newCenter.X;
			var yShifting = previouseCenter.Y - newCenter.Y;

			var points = quadrilateral.ToArray();
			for (var i = 0; i < points.Length; i++)
			{
				points[i].X -= xShifting;
				points[i].Y -= yShifting;
			}

			quadrilateral.Points = points.ToList();

			return quadrilateral;
		}
	}
}