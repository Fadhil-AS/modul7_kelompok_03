using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_03.DataMahasiswa__1302210009;

namespace modul7_kelompok_03
{
    internal class DataMahasiswa__1302210009
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }


        public Address address { get; set; }
        public List<MataKuliah> courses { get; set; }

        public DataMahasiswa__1302210009() { }
        public DataMahasiswa__1302210009(string firstName, string lastName, string gender, int age, Address address, List<MataKuliah> courses)
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
            String Des = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_1_1302210009.json");
            DataMahasiswa__1302210009 obj = JsonSerializer.Deserialize<DataMahasiswa__1302210009>(Des);
            Console.WriteLine("Nama: " + obj.firstName + " " + obj.lastName + " umur " + obj.age + " dengan jenis kelamin " + obj.gender);
            Console.WriteLine("Jalan " + obj.address.streetAddress + " Kota " + obj.address.city + " Provinsi " + obj.address.state);
            Console.WriteLine("Daftar mata kuliah yang diambil: ");
            for (int i = 0; i < obj.courses.Count; i++)
            {
                Console.WriteLine("Mata Kuliah " + (i + 1) + obj.courses[i].code + " - " + obj.courses[i].name);
            }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

            public Address() { }
            public Address(string streetAddress, string city, string state)
            {
                this.streetAddress = streetAddress;
                this.city = city;
                this.state = state;
            }
        }

        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
            public MataKuliah() { }
            public MataKuliah(string code, string name)
            {
                this.code = code;
                this.name = name;
            }
        }
    }
}
