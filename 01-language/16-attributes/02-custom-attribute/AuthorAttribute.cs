namespace RS2.Atributi;

[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
]
public class AuthorAttribute : System.Attribute
{
    private string name;
    public double version;

    public string GetName() { return name; } 

    public AuthorAttribute(string name)
    {
        this.name = name;
        version = 1.0;
    }
}