using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Practice
{     
    class Circle
    {
        public const double PI = Math.PI;
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double rad)
        {
            radius = rad;
        }
        public string FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }
        public double CalculateCircumference()
        {
            double circumference = PI * (radius * 2);
            return circumference;
        }
        //Allow for user input on number of decimal places
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            double area = PI * (radius * radius);
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }
    }
}