using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class members { 
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string gender { set; get; }
        public int age { set; get; }
        public string nim { set; get; }

        public members() { }
        public members(string firstName, string lastName, string gender, int age, string nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }
    internal class TeamMembers1302210006
    {
        public List<members> members { set; get; }

        public TeamMembers1302210006() { }
        public TeamMembers1302210006(List<members> members) {
            this.members = members;
        }

        public void ReadJSON() {
            String fr = File.ReadAllText(
                    "C:\\Users\\PRAKTIKAN\\Downloads\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_2_1302210006.json"
            );
            TeamMembers1302210006 obj = JsonSerializer.Deserialize<TeamMembers1302210006>(fr);
            Console.WriteLine("Team member list: ");
            for (int i = 0; i < obj.members.Count; i++) {
                Console.WriteLine(obj.members[i].nim + " " 
                    + obj.members[i].firstName + " " 
                    + obj.members[i].lastName + " "
                    + obj.members[i].age + " " + obj.members[i].gender);
            }
        }

    }
}
