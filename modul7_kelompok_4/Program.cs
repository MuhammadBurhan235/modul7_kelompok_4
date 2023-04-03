using System;

namespace modul7_kelompok_4
{
    class program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302210134 data = new DataMahasiswa1302210134();
            data.ReadJSON();
            Console.ReadKey();
        } 
    }
}