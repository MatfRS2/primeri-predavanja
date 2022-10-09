namespace RS2.Klase.ElementiPublic;

class Student
{
    // Polja brojIndeksa i imePrezime su privatna
    int brojIdneksa;
    string imePrezime;

    // Konstruktor 
    public Student(int bi, string ip)
    {
        brojIdneksa = bi;
        imePrezime = ip;
    }

    // Metodi getBrojIndeksa i getImePrezime su javni
    public int getBrojIndeksa()
    {
        return brojIdneksa;
    }

    public string getImePrezime()
    {
        return imePrezime;
    }
}