using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class DataMahasiswa1302213089
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public Address address { get; set; }

        public List<Matkul> courses { get; set; }

        public DataMahasiswa1302213089() { }

        public DataMahasiswa1302213089(string firstName, string lastName, string gender, int age, Address address, List<Matkul> courses)
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
            String Des = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Downloads\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_1_1302213089.json");

            DataMahasiswa1302213089 Obj = JsonSerializer.Deserialize<DataMahasiswa1302213089>(Des);
            Console.WriteLine("Nama : ");
            Console.WriteLine(Obj.firstName+" "+Obj.lastName);
            Console.WriteLine("JK : " + Obj.gender);
            Console.WriteLine("Usia : " + Obj.age);
            Console.WriteLine("Alamat ");
            Console.WriteLine("Kecamatan : " + Obj.address.streetAddress);
            Console.WriteLine("Kabupaten : "+Obj.address.city);
            Console.WriteLine("Provinsi : " + Obj.address.state);
            Console.WriteLine("Mengambil Mata Kuliah : ");
            for (int i = 0; i< Obj.courses.Count; i++)
            {
                Console.WriteLine("Kode MK : " + Obj.courses[i].code+"Nama MK : " + Obj.courses[i].name);
            }
        }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Address () { }

        public Address (string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }

    public class Matkul
    {
        public string code { get; set; }
        public string name { get; set; }

        public Matkul () { }

        public Matkul (string code, string name) 
        { 
            this.code = code;
            this.name = name;
        }
    }

}
