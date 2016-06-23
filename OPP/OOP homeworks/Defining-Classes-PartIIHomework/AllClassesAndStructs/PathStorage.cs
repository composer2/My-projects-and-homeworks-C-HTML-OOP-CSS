using System;
using System.IO;
using System.Linq;


namespace AllClassesAndStructs
{
    public static class PathStorage
    {
        public static void SaveFile(string pathFile, Path points)
        {

            using (StreamWriter writer = new StreamWriter(pathFile))
            {
                for (int i = 0; i < points.Points.Count; i++)
                {
                    writer.WriteLine(points.Points[i]);
                }
                writer.Close();
            }
        }

        public static Path LoadFile(string pathFile)
        {
            Path points = new Path();
            using (StreamReader reader = new StreamReader(pathFile))
            {
                string emptyLine = null;
                while ((emptyLine = reader.ReadLine()) != null)
                {
                    double[] pointCoordinates = emptyLine.Split(new char[] { ' ', '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                    Point3D point = new Point3D(pointCoordinates[0], pointCoordinates[2], pointCoordinates[2]);
                    points.Points.Add(point);
                }
                reader.Close();
            }
            return points;
        }
    }
}
