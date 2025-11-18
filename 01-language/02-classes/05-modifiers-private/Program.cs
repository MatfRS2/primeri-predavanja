/*
private Accessibility Level

Access is only granted to the containing class. 

Any other class inside the current or another assembly is not granted access to 
these members.
*/
using System;

namespace RS2.ModifiersPrivate
{

    class Roditelj
    {

        // Member is declared as private 
        private int value;

        // value is Accessible  
        // only inside the class 
        public void SetValue(int v)
        {
            value = v;
        }

        public int GetValue()
        {
            return value;
        }
    }

    class Potomak : Roditelj
    {

        public void ShowValue()
        {
            // Trying to access value 
            // Inside a derived class 
            // Console.WriteLine( "Value = " + value ); 
            // Gives an error 
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Roditelj obj = new Roditelj();

            // obj.value = 5; 
            // Also gives an error 

            // Use public functions to assign 
            // and use value of the member 'value' 
            obj.SetValue(4);
            Console.WriteLine("Value = " + obj.GetValue());
        }
    }
}

