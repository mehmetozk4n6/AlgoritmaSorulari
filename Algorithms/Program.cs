using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            questions soru = new questions();
            //soru.ciftOlanlariYazdir();
            //soru.tamBolunenleriYazdir();
            //soru.sondanBasaYazdir();
            soru.kelimeVeHarfSayisi();

            Console.ReadLine();
        }
    }

    class questions
    {
        public void ciftOlanlariYazdir()
        {
            Console.Write("Sayi Adedini Giriniz : ");
            string lines = Console.ReadLine();
            List<int> nums = new List<int>();
            for (int i = 0; i < int.Parse(lines); i++)
            {
                Console.Write("Sayi Giriniz : ");
                int line = int.Parse(Console.ReadLine());
                if (line % 2 == 0) nums.Add(line);
            }

            foreach(var j in nums)
            {
                Console.WriteLine(j);
            }
        }

        public void tamBolunenleriYazdir()
        {
            Console.Write("Bolunen Sayiyi Giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Sayi Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i=0; i<n;i++)
            {
                Console.Write("Sayi Giriniz : ");
                int num = int.Parse(Console.ReadLine());
                if (m % num == 0) nums.Add(num);
            }

            foreach (var j in nums)
            {
                Console.WriteLine(j);
            }
        }

        public void sondanBasaYazdir()
        {
            Console.Write("Kelime Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<string> kelimeler = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayi Giriniz : ");
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }

        public void kelimeVeHarfSayisi()
        {
            Console.Write("Cümle Giriniz : ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Console.WriteLine("Kelime Sayisi : {0}",words.Count());

            //Regex r = new Regex(@"\w");

            //Match m = r.Match(sentence);

            Console.WriteLine("Harf Sayisi : {0}", sentence.Count());

        }
    }




}
