using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseShape.Model.Entities;
using CourseShape.Model.Enums;

namespace CourseShape
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle() { Radius = 2.0, Color = Color.White };
            IShape rectangle = new Rectangle() { Width = 3.5, Heigth = 4.2, Color = Color.Black};
            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}
