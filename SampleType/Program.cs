using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyLibrary;

namespace SampleType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hitung objHitung = new Hitung();
            Console.Write("Masukan Alas :");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi :");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double hasil = objHitung.HitungSegitiga(alas, tinggi);
            Console.WriteLine("Hasilnya adalah : "+hasil);*/

            int a = 5;
            int b = a;
            a += 5;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Dosen dsn1 = new Dosen();
            dsn1.Nik = "223344";
            dsn1.Nama = "Erick";
            Dosen dsn2 = dsn1;

            Dosen dsn3 = new Dosen();
            dsn3.Nama = dsn1.Nama;

            dsn1.Nama = "Budi";
            Console.WriteLine("Dosen 1 : " + dsn1.Nama);
            Console.WriteLine("Dosen 2 : " + dsn2.Nama);
            Console.WriteLine("Dosen 3 : " + dsn3.Nama);
        }
    }
}
