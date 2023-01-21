using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double teotihuacan = 0;
      teotihuacan += rect(1500, 2500);
      teotihuacan += circle(375)/2;
      teotihuacan += triangle(750, 500);

      double flooringRate = 180;

      double flooringCost = Math.Round(teotihuacan * flooringRate, 2);

      Console.WriteLine(flooringCost);
    }

    static double rect(double length, double width)
    {
      return length * width;
    }

    static double circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double triangle(double bottom, double height)
    {
      return .5 * bottom * height;
    }
  }
}
