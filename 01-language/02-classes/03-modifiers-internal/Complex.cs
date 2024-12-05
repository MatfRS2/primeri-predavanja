using System; 

namespace RS2.ModifiersInternal { 

// Declare class Complex as internal 
internal class Complex { 

    int real; 
    int img; 

    internal void setData(int r, int i) 
    { 
        real = r; 
        img = i; 
    } 

    internal void displayData() 
    { 
        Console.WriteLine("Real = {0}", real); 
        Console.WriteLine("Imaginary = {0}", img); 
    } 
} 

}