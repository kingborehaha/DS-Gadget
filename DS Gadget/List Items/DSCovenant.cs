using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DS_Gadget
{
    class DSCovenant : IComparable<DSCovenant>
    {
        private static Regex CovenantEntryRx = new Regex(@"^(?<id>\d+) (?<name>.+)$");

        public byte ID { get; }
        public string Name { get; }

        public DSCovenant(byte id, string name)
        {
            ID = id;
            Name = name;
        }

        public int CompareTo(DSCovenant other) => Name.CompareTo(other.Name);

        public override string ToString() => Name;

        public static IReadOnlyList<DSCovenant> All { get; }

        static DSCovenant()
        {
            var all = new List<DSCovenant>();
            foreach (string line in Regex.Split(GetTxtResourceClass.GetTxtResource("Resources/Misc/Covenants.txt"), "[\r\n]+"))
            {
                if (GetTxtResourceClass.IsValidTxtResource(line)) //determine if line is a valid resource or not
                {
                    Match match = CovenantEntryRx.Match(line);
                    byte id = byte.Parse(match.Groups["id"].Value);
                    string name = match.Groups["name"].Value;
                    all.Add(new DSCovenant(id, name));
                }
            }
            all.Sort();
            All = all;
        }
    }
}
