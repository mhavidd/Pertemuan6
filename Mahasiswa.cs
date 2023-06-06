using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pertemuan5
{
    internal class Mahasiswa
    {
        public string nama;
        public int umur;
        public int nim;
        public string alamat;

        public void SetNama(string mhsNama)
        {
            nama = mhsNama;
        }

        public string GetNama()
        {
            return nama;
        }

        public void SetUmur(int mhsUmur)
        {
            umur = mhsUmur;
        }
        public int GetUmur()
        {
            return umur;
        }
        public void SetNim(int mhsNim)
        {
            nim = mhsNim;
        }
        public int GetNim()
        {
            return nim;
        }

        public void SetAlamat(string mhsAlamat)
        {
            alamat = mhsAlamat;
        }

        public string GetAlamat()
        {
            return alamat;
        }

        public void PrintInfo()
        {
            Console.WriteLine(" Nama Mahasiswa: {0}", GetNama());
            Console.WriteLine(" Umur Mahasiswa: {0}", GetUmur());
            Console.WriteLine(" Nim Mahasiswa: {0}", GetNim());
            Console.WriteLine(" Alamat Mahasiswa: {0}", GetAlamat());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.SetNama("Muhammad Havid Sulistyo");
            mahasiswa.SetUmur(19);
            mahasiswa.SetNim(22114859);
            mahasiswa.SetAlamat("Yogyakarta");

            mahasiswa.PrintInfo();
        }
    }
}