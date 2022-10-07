namespace RS2.Klase.NasledjivanjeKonstruktor;

class Student : Covek
{
    int brojIndeksa;

    // Konstruktor 
    public Student(int bi, string ip) : base(ip)
    {
        brojIndeksa = bi;
    }

    public int getBrojIndeksa()
    {
        return brojIndeksa;
    }

}

