namespace RS2.Klase.NasledjivanjeKonstruktor;

class Student : Covek
{
    readonly int brojIndeksa;

    // Konstruktor 
    public Student(int bi, string ip) : base(ip)
    {
        brojIndeksa = bi;
    }

    public Student(int bi) : this(bi, "Непознат студент")
    {
        brojIndeksa = bi;
    }

    public int getBrojIndeksa()
    {
        return brojIndeksa;
    }

}

