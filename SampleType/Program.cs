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
        enum Hari
        {
            senin,selasa,rabu,kamis,jumat,sabtu
        }

        static void Main(string[] args)
        {
            /*Hitung objHitung = new Hitung();
            Console.Write("Masukan Alas :");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi :");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double hasil = objHitung.HitungSegitiga(alas, tinggi);
            Console.WriteLine("Hasilnya adalah : "+hasil);*/

            /*int a = 5;
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

            Hari sekarang = Hari.rabu;

            switch (sekarang)
            {
                case Hari.senin:
                    Console.WriteLine("Hari senin");
                    break;
                case Hari.selasa:
                    Console.WriteLine("Hari selasa");
                    break;
            }*/

            //narrowing and widening
            //int a = 5;
            //double b = a;

            //double nilai1 = 2.45;
            ////convert
            //int nilai2 = Convert.ToInt32(nilai1);
            ////casting
            //int nilai3 = (int)nilai1;

            //Console.WriteLine(nilai2);

            //var nama = (nilai1 > 5) ? "hello" : "world";

            /*string[] arrNama = new string[5];
            arrNama[0] = "Erick";
            arrNama[1] = "Budi";
            arrNama[2] = "Deny";
            arrNama[3] = "Dewi";
            arrNama[4] = "Bambang";

            int[] arrNumber = new int[] { 3, 4, 55, 67, 34 };
            
            for(int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine(arrNama[i]);
            }

            foreach(int number in arrNumber)
            {
                Console.WriteLine(number);
            }*/

            /*double alas, tinggi, jari;
            alas = 12;
            tinggi = 12;
            Hitung objHitung = new Hitung();
            double hasil = objHitung.HitungSegitiga(alas, tinggi);
            jari = 25;
            double luas = objHitung.HitungLingkaran(ref jari);

            Console.WriteLine(alas);
            Console.WriteLine(tinggi);
            Console.WriteLine(jari);

            Console.WriteLine("hasil :" + hasil);
            Console.WriteLine("hasil luas lingkaran :" + jari);

            Mahasiswa outparam;
            string outparam2 = "";
            double hasilpersegi = objHitung.HitungPersegi(12, 14, out outparam,out outparam2);

            Console.WriteLine("Luas Persegi :" + hasilpersegi);
            Console.WriteLine(outparam);

            string result = MyHelper.SambungKata("Erick", "Kurniawan");
            Console.WriteLine(result);*/

            /*Mahasiswa mhs1;
            mhs1.Nim = "334455";
            mhs1.Nama = "Erick";

            Mahasiswa mhs2;
            mhs2.Nim = "445566";
            mhs2.Nama = "Budi";

            List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();
            listMahasiswa.Add(mhs1);
            listMahasiswa.Add(mhs2);

            Console.WriteLine(listMahasiswa[0].Nim + " " + listMahasiswa[0].Nama);
            foreach(var mhs in listMahasiswa)
            {
                Console.WriteLine("Nim : " + mhs.Nim + " Nama : " + mhs.Nama);
            }*/

            Queue<Dosen> queue = new Queue<Dosen>();
            //Dosen d1 = new Dosen { Nik = "889988", Nama = "Erick" };
            queue.Enqueue(new Dosen { Nik = "889988", Nama = "Erick" });


            
        }
    }
}
