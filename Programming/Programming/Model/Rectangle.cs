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
                Model.Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "Height");
                _height = value;
            }
        }

        public Model.Point2D Center { get; } = new Model.Point2D();

        public string Color { get; set; } = "Black";

        public Rectangle(double width, double height, string color, Model.Point2D center)
        {
            Width = width;
            Height = height;
            Color = color;
            Center = center;
        }

        public Rectangle() { }
    }
}
