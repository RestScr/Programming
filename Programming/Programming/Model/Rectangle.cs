using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _width = 0;
        private double _height = 0;

        public double Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("The width value cannot be below zero");
                }
                _width = value;
            }
        }

        private double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("The height value cannot be below zero");
                }
                _height = value;
            }
        }

        public string Color { get; set; } = "Black";

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public Rectangle() { }
    }
}
