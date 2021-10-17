using System; 

public class Roditelj { 

    // Declaring member as protected internal 
    protected internal int value; 
} 

class ABC { 

    // Trying to access  
    // value in another class 
    public void ProveriPristup() 
    { 
        Roditelj obj1 = new Roditelj(); 
        obj1.value = 12; 
        Console.WriteLine("Value = " + obj1.value);
    } 
} 