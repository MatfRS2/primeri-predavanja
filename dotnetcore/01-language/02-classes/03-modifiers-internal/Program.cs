/*
internal Accessibility Level

Access is limited to only the current Assembly, that is any class or type 
declared as internal is accessible anywhere inside the same namespace. 

It is the default access modifier in C#.
*/

//namespace RS2.DiffernetFromModifiersInternal { 
namespace RS2.ModifiersInternal
{


    class Program { 

    // Main Method 
    static void Main(string[] args) 
    { 
        // Instantiate the class Complex 
        // in separate class but within  
        // the same assembly 
        Complex c = new Complex(); 

        // Accessible in class Program 
        c.setData(2, 1); 
        c.displayData(); 
    } 
} 


} 