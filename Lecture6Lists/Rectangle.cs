using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lists
{
    public class Rectangle
    {
        //Fields
        private String name;
        private double length;
        private double width;

        //Constructors

        public Rectangle(string name, double length, double width)
        {
            this.name = name;
            this.length = length;
            this.width = width;
        }
        //Constructor takes a name and generates two random values for length and width
        public Rectangle(string name)
        {
            Random rand = new Random();
            this.name = name;
            this.length = rand.Next(1, 100);
            this.width = rand.Next(1, 100);
        }

        //Properties

        //Getters
        public String getName() { return name; }
        public double getLength() { return length; }
        public double getWidth() { return width; }


        //Methods
        public override string ToString()
        {
            return $"Name: {this.name} - Length: {this.length} Width: {this.width} Area: {this.width*this.length}";
        }
    }
}
