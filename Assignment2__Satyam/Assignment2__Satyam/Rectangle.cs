using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2__Satyam
{
    public class Rectangle
    {

        //attributes declared
        private int length;
        private int width;

        //default constructor to hold value
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //non-default constructor to hold value
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //method 1
        public int GetLength()
        {
            return length;
        }

        //method 2
        public int SetLength(int length)
        {
            this.length = length;
            if (length <= 0)
            {
                throw new Exception("Please enter valid input");
            }
            return length;
        }

        //method 3
        public int GetWidth()
        {
            return width;
        }

        //method 4
        public int SetWidth(int width)
        {
            this.width = width;
            if (width <= 0)
            {
                throw new Exception("Please enter valid input");
            }
            return width;
        }

        //method 5
        public int GetPerimeter()
        {
            int rectanglePerimeter;
            rectanglePerimeter = 2 * (length + width);

            if (length == 0 || width == 0)
            {
                throw new Exception("Incorrect length");
            }
            return rectanglePerimeter;

        }

        //method 6
        public int GetArea()
        {
            int rectangleArea;
            rectangleArea = length * width;

            if (length == 0 || width == 0)
            {
                throw new Exception("Incorrect length");
            }
            return rectangleArea;
        }
    }
}
