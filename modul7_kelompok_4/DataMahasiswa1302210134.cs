using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_4
{
    internal class DataMahasiswa1302210134
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        
        public class address{
            public address alamat { get; set; }
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

        }

        public class courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public List<courses> DaftarMK { get; set; }
        public void ReadJSON()
        {
            try
            {
                string jsonString = File.ReadAllText("D://Cha//modul7_kelompok_4//modul7_kelompok_4//jurnal7_1_1302210134.json");
                DataMahasiswa1302210134 data = JsonSerializer.Deserialize<DataMahasiswa1302210134>(jsonString);
                Console.WriteLine("Nama " + data.firstName + data.lastName + " dengan jenis kelamin " + data.gender + " dan umur " + data.age + "." + 
                                  " Yang beralamat " + data.alamat.streetAddress + data.alamat.city + data.alamat.state + ".");
                Console.WriteLine("Daftar mata kuliah yang diambil");
                int i = 1;
                foreach(courses MK in DaftarMK)
                {
                    Console.WriteLine("Mata Kuliah :" + i +" :" + MK.code + MK.name);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

    }
}
