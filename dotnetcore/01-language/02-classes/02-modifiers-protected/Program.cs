/*
protected Accessibility Level

Access is limited to the class that contains the member and derived types of 
this class. 

It means a class which is the subclass of the containing class anywhere in the 
program can access the protected members.
*/
using System; 

namespace RS2.ModifiersProtected { 

class X { 

    // Member x declared as protected 
    protected int x; 

    public X() 
    { 
        x = 10; 
    } 
} 

class Y : X { 

    // Members of Y can access 'x' 
    public int getX() 
    { 
        return x; 
    } 
} 

class Program { 

    static void Main(string[] args) 
    { 
        X obj1 = new X(); 
        Y obj2 = new Y(); 

        // Displaying the value of x 
        Console.WriteLine("Value of x is : {0}", obj2.getX()); 
    } 
} 

} 