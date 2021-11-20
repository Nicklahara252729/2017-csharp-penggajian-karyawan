using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenggajianKaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            int GajiPokok     = 150000,
                GajiMakan     = 50000,
                GajiTransport = 55000,
                Hours, lembur, GajiNormal ;
            double SumLembur,SumGaji;
            string JamKerja;
            x:
            Console.WriteLine(" ==============================================");
            Console.WriteLine("  APLIKASI PERHITUNGAN GAJI KARYAWAN SEDERHANA ");
            Console.WriteLine(" ==============================================");
            Console.WriteLine();
            Console.Write(" Masukkan Jumlah Jam Kerja : ");
            JamKerja   = Console.ReadLine();
            Hours      = Convert.ToInt32(JamKerja);

            lembur     = Hours - 7;
            GajiNormal = 7 * GajiPokok;
            SumLembur  = (GajiPokok * 1.5) * lembur;
            SumGaji = GajiMakan + GajiNormal + GajiTransport + SumLembur;
            if (Hours > 7)
            {
                Console.WriteLine(" Jam kerja normal : 7 jam ");
                Console.WriteLine(" Jam lembur anda  : " + lembur + " jam ");
                Console.WriteLine(" Total jam kerja  : " + Hours + " jam");
                Console.WriteLine();
                Console.WriteLine(" ==============================================");
                Console.WriteLine("           Total Gaji Yang Di Dapat            ");
                Console.WriteLine(" ==============================================");
                Console.WriteLine();
                Console.WriteLine(" Gaji Normal     : Rp." + GajiNormal);
                Console.WriteLine(" Gaji Lembur     : Rp." + SumLembur);   
                if (Hours > 8 )
                {
                    Console.WriteLine(" Gaji Makan      : Rp." + GajiMakan);
                }
                else
                {
                    Console.WriteLine(" Gaji Makan      : Rp. 0");
                }
                if (Hours > 9)
                {
                    Console.WriteLine(" Gaji Transport  : Rp." + GajiTransport);
                }
                else
                {
                    Console.WriteLine(" Gaji Transport  : Rp. 0");
                }
                Console.WriteLine();
                Console.WriteLine(" Total Gaji      : Rp." + SumGaji);
            }
            else
            {
                Console.WriteLine(" Jam kerja normal : 7 jam ");
                Console.WriteLine(" Jam lembur anda  : 0 jam ");
                Console.WriteLine(" Total jam kerja  : " + Hours + " jam");
                Console.WriteLine();
                Console.WriteLine(" ==============================================");
                Console.WriteLine("           Total Gaji Yang Di Dapat            ");
                Console.WriteLine(" ==============================================");
                Console.WriteLine();
                Console.WriteLine(" Gaji Normal     : Rp." + GajiNormal);
                Console.WriteLine(" Gaji Lembur     : Rp. 0" );
                Console.WriteLine(" Gaji Makan      : Rp. 0" );
                Console.WriteLine(" Gaji Transport  : Rp. 0" );
                Console.WriteLine();
                Console.WriteLine(" Total Gaji      : Rp." + GajiNormal);
            }   
            Console.WriteLine();
            Console.WriteLine(" ==============================================");
            Console.WriteLine("           Copyright(c)nicolahara              ");
            Console.WriteLine(" ==============================================");
            
            Console.Write(" Do it Again ? (Y/N) ");
            string again = Console.ReadLine();
            if (again == "Y" || again == "y")
            {
                Console.Clear();
                goto x;
            }
                Console.Read();
        }
    }
}
