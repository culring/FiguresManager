using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Figure
    {
        public enum FigureType
        {
            Triangle = 0,
            Square = 1,
            Circle = 2
        };

        public Color Color { get; set; }
        public FigureType Type { get; set; }
        public Tuple<double, double> Coordinates { get; set; }
        public double Area { get; set; }
        public string Label { get; set; }

        public Figure(Color color, FigureType figureType, Tuple<double, double> coordinates,
            double area, string label)
        {
            Color = color;
            Type = figureType;
            Coordinates = coordinates;
            Area = area;
            Label = label;
        }

        public static string ColorToHexString(Color color)
        {
            return @"#" +
                color.A.ToString("X2") +
                color.R.ToString("X2") +
                color.G.ToString("X2") +
                color.B.ToString("X2");
        }
    }
}
