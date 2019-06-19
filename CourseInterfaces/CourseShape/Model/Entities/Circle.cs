using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseShape.Model.Enums;

namespace CourseShape.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = " + Color + ", radius = " + Radius.ToString("F2", CultureInfo.InstalledUICulture) + ", area = " + Area().ToString("F2", CultureInfo.InstalledUICulture) ;
        }
    }
}
