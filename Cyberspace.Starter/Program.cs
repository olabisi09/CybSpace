using System;


namespace Cyberspace.Starter
{
    public class Program
    {
        public static void Main()
        {
            var p = new Point[9];
            var line = new Line(p);
            
        }
        
    }

    public interface ICompress
    {
        int Read();
    }
    public interface IDrive
    {
        int Write();
    }

    public struct Line
    {
        public Line(Point[] points)
        {
            Points = points;
        }
        public Point[] Points { get; set; }
    }

    public enum Gender
    {
        male, female
    }
    public enum UnitTypes
    {
        Millimeters = 12, Centimeters = 25
    }
    public class Point
    {
        public UnitTypes unit { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return ($"X = {X} {unit}, Y = {Y} {unit}");
        }
    }

}
