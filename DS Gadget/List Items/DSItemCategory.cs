using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DS_Gadget
{
    class DSItemCategory
    {
        public string Name;
        public int ID;
        public List<DSItem> Items;

        private DSItemCategory(string name, int id, string itemList, bool showIDs)
        {
            Name = name;
            ID = id;
            Items = new List<DSItem>();
            foreach (string line in Regex.Split(itemList, "[\r\n]+"))
            {
                if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
                    Items.Add(new DSItem(line, showIDs));
            };
            Items.Sort();
        }

        public override string ToString()
        {
            return Name;
        }

        public static void GetItemCategories()
        {
            foreach (string line in Regex.Split(GetTxtResourceClass.GetTxtResource("Resources/DSItemCategories.txt"), "[\r\n]+"))
            {
                if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
                {
                    var att = Regex.Split(line, ",");
                    Array.ForEach<string>(att, x => att[Array.IndexOf<string>(att, x)] = x.Trim());
                    All.Add(new DSItemCategory(att[0].Trim(), Convert.ToInt32(att[1].Trim(), 16), GetTxtResourceClass.GetTxtResource(att[2].Trim()), bool.Parse(att[3])));
                }
            };
        }

        public static List<DSItemCategory> All = new List<DSItemCategory>();
    }
}
