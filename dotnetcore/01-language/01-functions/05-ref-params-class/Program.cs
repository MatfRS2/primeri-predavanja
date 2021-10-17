using System;

namespace RS2.N05RefParamsClass
{

    class Complex
    {

        private int real, img;

        public Complex(int r, int i)
        {
            real = r;
            img = i;
        }

        public int getRealValue()
        {
            return real;
        }

        public int getImgValue()
        {
            return img;
        }

        public static void Update(ref Complex obj)
        {
            obj.real += 5;
            obj.img += 5;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Complex cmplx = new Complex(2, 4);
            Console.WriteLine("Complex number {0} =  {1} + i {2}", nameof(cmplx),
                cmplx.getRealValue(), cmplx.getImgValue());

            Complex.Update(ref cmplx);
            Console.WriteLine("After updating {0}", nameof(cmplx) );
            Console.WriteLine("Complex number {0} =  {1} + i {2}", nameof(cmplx),
                cmplx.getRealValue(), cmplx.getImgValue());
        }

    }

}