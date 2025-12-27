namespace RS2.LambdaIndexer
{
    class Elementi<T> where T : class
    {
        private T[] skladiste;

        public Elementi()
        {
            skladiste = new T[10];
        }

        public Elementi(int dimenzija)
        {
            skladiste = new T[dimenzija];
        }

        public T this[int index]
        {
            get => skladiste[index];

            set => skladiste[index] = value;
        }

        public int Dimenzija { 
            get { return skladiste.Length; } 
        }
    }
}
