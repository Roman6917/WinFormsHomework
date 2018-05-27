using Quadrilateral_Task2.POCO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Quadrilateral_Task2.Utils;

namespace Quadrilateral_Task2.BL
{
    public class QuadrilateralBL
    {
        public static List<string> LoadFiguresList()
        {
            List<string> files = null;
            string path = IOUtils.GetDataDirectoryPath();
            if (Directory.Exists(path))
            {
                files = new List<string>(Directory.GetFiles(path).Where(p => Path.GetExtension(p) == ".xml").Select(q => Path.GetFileName(q)));
            }

            return files;
        }

        public static List<Quadrilateral> LoadFigures(string fileName)
        {
            string path = IOUtils.GetDataDirectoryPath() + "\\" + fileName;
            if (!File.Exists(path))
            {
                throw new IOException(string.Format("can not find file : {0}", path));
            }
            List<Quadrilateral> quadrilaterals = QuadrilateralBL.DeserializeList(path);

            return quadrilaterals;
        }

        public static void SerializeList(List<Quadrilateral> quadrilaterals, string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Quadrilateral>));
            quadrilaterals.ForEach(p => p.RgbaColor = p.Color.ToArgb());
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, quadrilaterals);
            }
        }

        public static List<Quadrilateral> DeserializeList(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Quadrilateral>));
            List<Quadrilateral> quadrilaterals = null;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                quadrilaterals = (List<Quadrilateral>)formatter.Deserialize(fs);
            }

            if (quadrilaterals == null)
            {
                throw new ApplicationException(string.Format("cannot deserialize file {0}", path));
            }
            quadrilaterals.ForEach(p => p.Color = Color.FromArgb(p.RgbaColor));

            return quadrilaterals;
        }

        public static Quadrilateral MoveToPoint(Quadrilateral quadrilateral, Point newCenter)
        {
            Point previouseCenter = quadrilateral.Center();
            int xShifting = previouseCenter.X - newCenter.X;
            int yShifting = previouseCenter.Y - newCenter.Y;

            var points = quadrilateral.ToArray();
            for (int i = 0; i < points.Count(); i++)
            {
                points[i].X -= xShifting;
                points[i].Y -= yShifting;
            }
            quadrilateral.Points = points.ToList();

            return quadrilateral;
        }

    }
}
