using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class TeamMembers1302213089
    {
        public List<DataAnggota> members { get; set; }

        public TeamMembers1302213089() { }

        public TeamMembers1302213089(List<DataAnggota> members)
        {
            this.members = members;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Downloads\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_2_1302213089.json");

            TeamMembers1302213089 Obj = JsonSerializer.Deserialize<TeamMembers1302213089>(Des);
            Console.WriteLine("Team member list:");
            for (int i = 0; i < Obj.members.Count; i++)
            {
                Console.WriteLine(Obj.members[i].nim+" " + Obj.members[i].firstName+" " + Obj.members[i].lastName+" " + Obj.members[i].age+" " + Obj.members[i].gender);
            }
        }
    }

    public class DataAnggota
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public DataAnggota() { }

        public DataAnggota(string firstName, string lastName, string gender, int age, string nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }
}
