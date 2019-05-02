﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrogaman tahun 2018/2019";
            Karyawan ObjKaryawan = new Karyawan("02132901", "zaky", 4000000);
            Karyawan ObjKaryawan2 = new Karyawan("02132902", "aziz", 5000000);

            Hasil(ObjKaryawan, ObjKaryawan2);

            Console.WriteLine("Asyiiiiikkkk Kenaikan Gaji 10%");
            Console.WriteLine();

            var result = (0.10 * ObjKaryawan.GajiBulanan) + ObjKaryawan.GajiBulanan;
            var result2 = (0.10 * ObjKaryawan2.GajiBulanan) + ObjKaryawan2.GajiBulanan;
            ObjKaryawan.GajiBulanan = Convert.ToInt32(result);
            ObjKaryawan2.GajiBulanan = Convert.ToInt32(result2);

            Hasil(ObjKaryawan, ObjKaryawan2);

            Console.ReadKey();
        }

        static void Hasil(Karyawan karyawan, Karyawan karyawan2)
        {
            Console.WriteLine("No. Nik     Nama\t Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("1. ");
            Console.Write("{0} {1}\t", karyawan.Nik, karyawan.Nama);
            Console.Write("\t{0}", karyawan.GajiBulanan);
            Console.WriteLine();
            Console.Write("2. ");
            Console.Write("{0} {1}\t", karyawan2.Nik, karyawan2.Nama);
            Console.WriteLine("\t{0}", karyawan2.GajiBulanan);
            Console.WriteLine();
        }
    }
}