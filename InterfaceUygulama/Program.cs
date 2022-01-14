using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Program
    {
        public interface Islem
        {
            void topla(int sayi1, int sayi2);
            void carp(int sayi1, int sayi2);
        }
        public class Hesap : Islem
        {
            public void carp(int sayi1,int sayi2)
            {
                Console.WriteLine(sayi1+"x"+sayi2+"="+sayi2*sayi1);
            }
            public void topla(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi2 + sayi1));
            }

        }

        static void Main(string[] args)
        {
            Hesap hesap = new Hesap();
            hesap.topla(5,10);
            hesap.carp(5,10);

            Console.ReadLine();
        }
    }
}
