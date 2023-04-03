using System;

namespace modul7_kelompok_4
{
    class program
    {
        static void Main(String[] args)
        {
            DataMahasiswa_1302210100_Hasnan data = new DataMahasiswa_1302210100_Hasnan();
            data.ReadJSON();
            Console.ReadKey();
        }
    }
}

