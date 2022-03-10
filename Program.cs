using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotTanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;  
            Console.WriteLine(a + b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYAzdir(Convert.ToString(sonuc));

            int sonuc2= ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYAzdir(Convert.ToString(sonuc2));
            ornek.EkranaYAzdir(Convert.ToString(a+b));

        }
        static int Topla( int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }
    class Metotlar
    {
        public void EkranaYAzdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}
