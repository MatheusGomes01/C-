using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseShape.Model.Enums;

namespace CourseShape.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectangle color = " + Color + ", width = " + Width.ToString("F2", CultureInfo.InvariantCulture) +
                   ", heigth = " + Heigth.ToString("F2", CultureInfo.InvariantCulture) + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
