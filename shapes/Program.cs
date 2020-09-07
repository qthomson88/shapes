using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class shape
    {
        internal int length;
        internal int height;
        internal int area;
        internal int perimeter;

        public shape()
        {
            length = 0;
            height = 0;
            area = 0;
            perimeter = 0;
        }
        public void setparams()
        {
            Console.WriteLine("input the length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the height");
            height = Convert.ToInt32(Console.ReadLine());
            calculateArea();
            calculatePerimeter();
        }

        private int getArea()
        {
            return area;
        }

        private int getPerimeter()
        {
            return perimeter;
        }

        public virtual void calculateArea()
        {
            Console.WriteLine("This calculates the area");
        }

        public virtual void calculatePerimeter()
        {
            Console.WriteLine("This calculates the perimeter");
        }


        public void display()
        {
            Console.WriteLine("The area is {0}", getArea());
            Console.WriteLine("The perimeter is {0}", getPerimeter());
        }

        //I want to make a base class shape that calculates the perimeter and the area of shapes
        //There will be two inherited classes, triangle and rectangle
        //the functions calculate the area, and the perimeter will be different
        //Make a display function in the parent class
    }

    class triangle : shape
    {
        public override void calculateArea()
        {
            area = (length * height)/2;
        }

        //for simplicity assume a regular triangle
        public override void calculatePerimeter()
        {
            perimeter = 3*length;
        }
    }

    class rectangle : shape
    {
        public override void calculateArea()
        {
            area = length * height;
        }

        //for simplicity assume a regular triangle
        public override void calculatePerimeter()
        {
            perimeter = (2 * height) + (2 * length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char userSelect;
            shape myShape = new shape();


            Console.WriteLine("What kind of shape do you want?");
            Console.WriteLine("(t)riangle");
            Console.WriteLine("(r)ectangle");
            userSelect = Convert.ToChar(Console.ReadLine());

            switch(userSelect)
            {
                case 't':
                    myShape = new triangle();
                    myShape.setparams();
                    break;

                case 'r':
                    myShape = new rectangle();
                    myShape.setparams();
                    break;
            }

            myShape.display();
            Console.ReadKey();
        }
    }
}
