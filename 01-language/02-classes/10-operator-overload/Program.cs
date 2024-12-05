
using System;

namespace RS2.OperatorOverload
{
    class Box
    {
        private double length;    // Length of a box
        private double breadth;   // Breadth of a box
        private double height;    // Height of a box

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.breadth == rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            if (lhs.length != rhs.length || lhs.height != rhs.height ||
               lhs.breadth != rhs.breadth)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            if (lhs.length < rhs.length && lhs.height < rhs.height
               && lhs.breadth < rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator >(Box lhs, Box rhs)
        {
            if (lhs.length > rhs.length && lhs.height >
               rhs.height && lhs.breadth > rhs.breadth)
            {

                return true;
            }
            return false;
        }
        public static bool operator <=(Box lhs, Box rhs)
        {
            if (lhs.length <= rhs.length && lhs.height
               <= rhs.height && lhs.breadth <= rhs.breadth)
            { 
                return true;
            }
            return false;
        }
        public static bool operator >=(Box lhs, Box rhs)
        {
            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

        public override bool Equals(object obj)
        {
            if (obj is Box)
            {
                return this == (Box)obj;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return 5 * (length).GetHashCode()
                + 7 * (breadth).GetHashCode()
                + 11 * (height).GetHashCode();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();   // Declare Box1 of type Box
  
            // box 1 specification
            box1.setLength(6.0);
            box1.setBreadth(7.0);
            box1.setHeight(5.0);

            Box box2 = new Box();   // Declare Box2 of type Box
                                    
            // box 2 specification
            box2.setLength(12.0);
            box2.setBreadth(13.0);
            box2.setHeight(10.0);

            //displaying the Boxes using the overloaded ToString():
            Console.WriteLine("Box 1: {0}", box1.ToString());
            Console.WriteLine("Box 2: {0}", box2.ToString());

            double volume = 0.0;    // Store the volume of a box here
                                    // volume of box 1
            volume = box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box box3 = box1 + box2;
            Console.WriteLine("Box 3: {0}", box3.ToString());

            // volume of box 3
            volume = box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

            //comparing the boxes
            if (box1 > box2)
                Console.WriteLine("Box1 is greater than Box2");
            else
                Console.WriteLine("Box1 is not greater than Box2");

            if (box1 < box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");

            if (box1 >= box2)
                Console.WriteLine("Box1 is greater or equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");

            if (box1 <= box2)
                Console.WriteLine("Box1 is less or equal to Box2");
            else
                Console.WriteLine("Box1 is not less or equal to Box2");

            if (box1 != box2)
                Console.WriteLine("Box1 is not equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");
            Box box4 = box3;

            if (box3 == box4)
                Console.WriteLine("Box3 is equal to Box4");
            else
                Console.WriteLine("Box3 is not equal to Box4");
        }
    }
}
