namespace RS2.Klase.ElementiPublic;

class Student
{
    // Polja brojIndeksa i imePrezime su privatna
    readonly int brojIndeksa;
    readonly string imePrezime;

    // Konstruktor 
    public Student(int bi, string ip)
    {
        brojIndeksa = bi;
        imePrezime = ip;
    }

    // Metodi getBrojIndeksa i getImePrezime su javni
    public int getBrojIndeksa()
    {
        return brojIndeksa;
    }

    public string getImePrezime()
    {
        return imePrezime;
    }
}