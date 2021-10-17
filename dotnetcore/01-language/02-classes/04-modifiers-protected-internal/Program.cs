/*
protected internal Accessibility Level

Access is limited to the current assembly or the derived types of the 
containing class. It means access is granted to any class which is derived from 
the containing class within or outside the current Assembly.
*/
using System; 

namespace RS2.ModifiersProtectedInternal { 

class Potomak : Roditelj { 

    public static void Main(String[] args) 
    { 
        // Accessing value in another assembly 
        Potomak obj3 = new Potomak(); 
        // Member value is Accessible 
        obj3.value = 9; 
        Console.WriteLine("Value = " + obj3.value);

        ABC obj4 = new ABC();
        obj4.ProveriPristup();
    } 
} 
} 
