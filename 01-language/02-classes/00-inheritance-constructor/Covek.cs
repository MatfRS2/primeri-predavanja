namespace RS2.Klase.NasledjivanjeKonstruktor;

class Covek
{
    readonly string imePrezime;

    public Covek(string ip)
    {
        imePrezime = ip;
    }

    public string GetImePrezime()
    {
        return imePrezime;
    }

}
