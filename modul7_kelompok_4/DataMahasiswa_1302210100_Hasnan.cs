using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_4
{
    internal class DataMahasiswa_1302210100_Hasnan
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address alamat { get; set; }
        public courses MK { get; set; }

        public class address
        { 
            public string street { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class courses
        {
            public string name { get; set; }
            public string code { get; set; }
        }

        public List<courses> courses1 { get; set; }
        public void ReadJSON()
        {
            try
            {
                string jsonString = File.ReadAllText("jurnal7_1_1302210100.json");
                DataMahasiswa_1302210100_Hasnan data = JsonSerializer.Deserialize<DataMahasiswa_1302210100_Hasnan>(jsonString);
                Console.WriteLine("Nama   : " + data.firstName + data.lastName + " \nGender : " + data.gender + "\nUmur   : " + data.age + "," +
                    "\nAlamat : " + data.alamat.street + " " + data.alamat.city + " " + data.alamat.state);
                Console.WriteLine("Daftar Matkul Yang di Pilih : ");
                    int i = 1;
                foreach (courses c in courses1)
                {
                    Console.WriteLine("Mata Kuliah " + i + " : " + c.code + " - " + c.name);
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
