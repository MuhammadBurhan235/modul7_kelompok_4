using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_4
{
    internal class DataMahasiswa_1302213109
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address alamat { get; set; }
        public courses matkul { get; set; }
        public class address
        {
            public address() { }
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
                string jsonString = File.ReadAllText("jurnal7_1_1302213109.json");
                DataMahasiswa_1302213109 data = JsonSerializer.Deserialize<DataMahasiswa_1302213109>(jsonString);
                Console.WriteLine("Nama " + data.firstName + data.lastName + " dengan jenis kelamin " +data.gender+ " dan umur " +data.age+ "." 
                                    + "Ia beralamat ");
                Console.WriteLine("Daftar Mata Kuliah yang Ia pelajari:");

                int i = 1;
                foreach(courses c in DaftarMK)
                {
                    Console.WriteLine("Mata Kuliah " + i + ": "+ c.code +" - "+ c.name);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
