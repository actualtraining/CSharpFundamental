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

        public double HitungPersegi(double panjang,double lebar,out string outparam)
        {
            outparam = "ditambahkan di method HitungPersegi";
            double hasil = panjang * lebar;
            return hasil;    
        }
    }
}
