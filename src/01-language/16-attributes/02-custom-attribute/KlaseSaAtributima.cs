using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2.Atributi;

// Class with the Author attribute.  
[Author("P. Ackerman")]
public class FirstClass
{
    // ...  
}

// Class without the Author attribute.  
public class SecondClass
{
    // ...  
}

// Class with multiple Author attributes.  
[Author("R. Koch", version = 2.0)]
public class ThirdClass
{
    // ...  
}

