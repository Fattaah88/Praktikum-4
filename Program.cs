using System;

class Mahasiswa
{
    public string NIM;
    public string Nama;
    public float Nilai;
}

namespace Pertemuan_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa[] Mhs = new Mahasiswa[3];

            //menginput data mhs
            for (int i = 0; i < Mhs.Length; i++)
            {
                Mhs[i] = new Mahasiswa();

                Console.WriteLine("Data Mahasiswa ke-" + (i + 1));
                Console.Write("Nama\t: ");
                Mhs[i].Nama = Console.ReadLine();
                Console.Write("NIM\t: ");
                Mhs[i].NIM = Console.ReadLine();
                Console.Write("Nilai\t: ");
                Mhs[i].Nilai = int.Parse(Console.ReadLine());
            }

            //mencari nilai tertinggi
            float maxNilai = 0;
            string maxNIM = "", maxNama = "";

            for (int i = 0; i < Mhs.Length; i++)
            {
                if (Mhs[i].Nilai > maxNilai)
                {
                    maxNilai = Mhs[i].Nilai;
                    maxNIM = Mhs[i].NIM;
                    maxNama = Mhs[i].Nama;
                }
            }

            //mencari nilai terendah
            float minNilai = 100;
            string minNIM = "", minNama = "";

            for (int i = 0; i < Mhs.Length; i++)
            {
                if (Mhs[i].Nilai < minNilai)
                {
                    minNilai = Mhs[i].Nilai;
                    minNIM = Mhs[i].NIM;
                    minNama = Mhs[i].Nama;
                }
            }

        //output nilai tetinggi
        Console.WriteLine("Mahasiswa dengan nilai tertinggi: ");
        Console.WriteLine("Nama\t : " + maxNama);
        Console.WriteLine("NIM\t : " + maxNIM);
        Console.WriteLine("Nilai\t : " + maxNilai);
        Console.WriteLine();
        Console.WriteLine("Mahasiswa dengan nilai tertinggi: ");
        Console.WriteLine("Nama\t : " + minNama);
        Console.WriteLine("NIM\t : " + minNIM);
        Console.WriteLine("Nilai\t : " + minNilai);
        }
    }
}
