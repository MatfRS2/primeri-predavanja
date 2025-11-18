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

    // Metodi GetBrojIndeksa i GetImePrezime su javni
    public int GetBrojIndeksa()
    {
        return brojIndeksa;
    }

    public string GetImePrezime()
    {
        return imePrezime;
    }
}