using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    internal class teamMember_1302210009
    {
        public List<DataMember> members { get; set; }
        public teamMember_1302210009() { }
        public teamMember_1302210009(List<DataMember> members)
        {
            this.members = members;
        }
        public void ReadJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_2_1302210009.json");
            teamMember_1302210009 obj = JsonSerializer.Deserialize<teamMember_1302210009>(Des);

            Console.WriteLine("Team member list:");
            for (int i = 0; i < obj.members.Count; i++)
            {
                Console.WriteLine(obj.members[i].nim + " " + obj.members[i].firstName + " " + obj.members[i].lastName + " " + obj.members[i].age + " " + obj.members[i].gender);
            }

        }
        public class DataMember
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }

            public DataMember() { }

            public DataMember(string firstName, string lastName, string gender, int age, string nim)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.age = age;
                this.nim = nim;
            }
        }
    }
}
