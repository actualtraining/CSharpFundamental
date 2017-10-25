using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    
    public struct Mahasiswa
    {
        public string Nim;
        public string Nama;
    }
    public class Hitung
    {
        public double HitungSegitiga(double alas,double tinggi)
        {
            alas = 14;
            tinggi = 14;
            return 0.5 * alas * tinggi;
        }

        public double HitungLingkaran(ref double jari)
        {
            jari = 20;
            return 3.14 * jari * jari;
        }

        public double HitungPersegi(double panjang,double lebar,out Mahasiswa outparam, out string outparam2)
        {
            outparam2 = "Jadi panjang " + panjang.ToString();
            outparam.Nim = "334455";
            outparam.Nama = "Erick";

            double hasil = panjang * lebar;
            return hasil;
        }

        public double HitungPersegi(double panjang,double lebar)
        {
            return panjang * lebar;
        }

        public double HitungPersegi(int panjang,double lebar)
        {
            return 0;
        }
    }
}
