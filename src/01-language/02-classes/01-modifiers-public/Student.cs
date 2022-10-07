namespace RS2.Klase
{

    class Student
    {
        // Polja brojIndeksa i imePrezime su javna
        public int brojIdneksa;
        public string imePrezime;

        // Konstruktor 
        public Student(int bi, string ip)
        {
            brojIdneksa = bi;
            imePrezime = ip;
        }

        // Metodi getBrojIndeksa i getImePrezime su takođe javni
        public int getBrojIndeksa()
        {
            return brojIdneksa;
        }

        public string getImePrezime()
        {
            return imePrezime;
        }
    }
}