using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class courses { 
        public string code { set; get; }
        public string name { set; get; }
        public courses() { }
        public courses(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }

    public class address { 
        public string streetAddress { set; get; }
        public string city { set; get; }
        public string state { set; get; }
        public address() { }
        public address(string streetAddress, string city, string state) {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }

    internal class DataMahasiswa1302210006
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string gender { set; get; }
        public int age { set; get; }

        public address address { set; get; }
        public List<courses> courses { set; get; }

        public DataMahasiswa1302210006() { }

        public DataMahasiswa1302210006(string firstName, string lastName, string gender, int age, address address, List<courses> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }

        public void ReadJSON()
        {
            String fr = File.ReadAllText(
                    "C:\\Users\\PRAKTIKAN\\Downloads\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_1_1302210006.json"
            );
            DataMahasiswa1302210006 obj = JsonSerializer.Deserialize<DataMahasiswa1302210006>(fr);
            Console.WriteLine(
                "Data Mahasiswa:\n"
                + "Nama: " + obj.firstName + " " + obj.lastName + "\n"
                + "Jenis Kelamin: " + obj.gender + "\n"
                + "Alamat: " + obj.address.streetAddress + ", " + obj.address.city + ", " + obj.address.state + "\n"
            );
            Console.WriteLine("Mata Kuliah: ");
            for (int i = 0; i < obj.courses.Count; i++) {
                Console.WriteLine(obj.courses[i].code + " - " + obj.courses[i].name);
            }
            

        }
    }
}
