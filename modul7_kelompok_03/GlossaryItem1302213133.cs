using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    internal class GlossaryItem1302213133
    {
        public glossary glossary { get; set; }
        public GlossaryItem1302213133() { }
        public GlossaryItem1302213133(glossary glossary)
        {
            this.glossary = glossary;
        }

        public void ReadJSON()
        {
            String Des = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\GitHub\\modul7_kelompok_03\\modul7_kelompok_03\\jurnal7_3_1302213133.json");

            GlossaryItem1302213133 obj = JsonSerializer.Deserialize<GlossaryItem1302213133>(Des);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            for (int i = 0; i < obj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso.Length; i++)
            {
                Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[i]);
            }
            Console.WriteLine(obj.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }

    public class GlossDef1302213133
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
        public GlossDef1302213133() { }
        public GlossDef1302213133(string para, string[] GlossSeeAlso)
        {
            this.para = para;
            this.GlossSeeAlso = GlossSeeAlso;
        }
    }

    public class GlossEntry1302213133
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef1302213133 GlossDef { get; set; }
        public string GlossSee { get; set; }

        public GlossEntry1302213133() { }
        public GlossEntry1302213133(string ID, string SortAs, string GlossTerm, string Acronym, string Abbrev, GlossDef1302213133 GlossDef,
            string GlossSee)
        {
            this.ID = ID;
            this.SortAs = SortAs;
            this.GlossTerm = GlossTerm;
            this.Acronym = Acronym;
            this.Abbrev = Abbrev;
            this.GlossDef = GlossDef;
            this.GlossSee = GlossSee;
        }
    }

    public class GlossList1302213133
    {
        public GlossEntry1302213133 GlossEntry { get; set; }
        public GlossList1302213133() { }
        public GlossList1302213133(GlossEntry1302213133 GlossEntry)
        {
            this.GlossEntry = GlossEntry;
        }
    }

    public class GlossDiv1302213133
    {
        public string title { get; set; }
        public GlossList1302213133 GlossList { get; set; }

        public GlossDiv1302213133() { }
        public GlossDiv1302213133(string title, GlossList1302213133 GlossList)
        {
            this.title = title;
            this.GlossList = GlossList;
        }
    }

    public class glossary
    {
        public string title { get; set; }
        public GlossDiv1302213133 GlossDiv { get; set; }
        public glossary() { }
        public glossary(string title, GlossDiv1302213133 GlossDiv)
        {
            this.title = title;
            this.GlossDiv = GlossDiv;
        }
    }
}

