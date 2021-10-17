/*
private protected Accessibility Level

Access is granted to the containing class and its derived types present in the 
current assembly. 
*/
using System; 

namespace RS2.ModifiersPrivateProtected { 

class Roditelj { 

    // Member is declared as private protected 
    private protected int value; 

    // value is Accessible only inside the class 
    public void setValue(int v) 
    { 
        value = v; 
    } 
    public int getValue() 
    { 
        return value; 
    } 
} 

class Potomak : Roditelj { 

    public void ShowValue() 
    { 
        // Trying to access value 
        // Inside a derived class 
        Console.WriteLine("Value = " + value); 
        // value is accesible 
    } 
} 

class Program { 

    // Main Method 
    static void Main(string[] args) 
    { 
        Roditelj obj = new Roditelj(); 

        // obj.value = 5; 
        // Also gives an error 

        // Use public functions to assign 
        // and use value of the member 'value' 
        obj.setValue(4); 
        Console.WriteLine("Value = " + obj.getValue()); 
    } 
} 
} 