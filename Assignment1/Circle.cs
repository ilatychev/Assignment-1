using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(int newRadius)
        {
            radius = newRadius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int newRadius)
        {
            radius = newRadius;
        }

        public double GetCircumference()
        {
            return 2 * 3.14 * radius;
        }

        public double GetArea()
        {
            return 3.14 * radius * 2;
        } 
    }
}
