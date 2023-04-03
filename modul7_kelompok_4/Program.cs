using System;

namespace modul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302213109 data = new DataMahasiswa_1302213109();
            data.ReadJSON();
            Console.ReadKey();
        }
    }
}