using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleTester
{
    class Circle
    {
        //properties
        private double Radius;
        ////getter = a way to see the radius without changing it
        public double radius
        {
            get { return Radius; }
        }
        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //methods
        public double CalculateCircumference()
        {
            return 2 * radius * Math.PI;
        }
        public double CalculateArea()
        {
            return 2 * Math.PI * (radius * radius);
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());     
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());       
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }
    }
}
