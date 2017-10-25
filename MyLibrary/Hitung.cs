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
            return 0.5 * alas * tinggi;
        }
    }
}
