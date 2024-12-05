using System;

namespace RS2.InitializationExpression
{
    internal class Poruka
    {
        byte bp = 7;

        public byte BrojPonavljanja{
            get => bp;
            set => bp = value;
        }
        
        public string Sadrzaj {
            get;
            set;
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine("---");
            for(int i=0; i<BrojPonavljanja; i++)
                Console.WriteLine(Sadrzaj);
            Console.WriteLine("---");
        }
    }
}