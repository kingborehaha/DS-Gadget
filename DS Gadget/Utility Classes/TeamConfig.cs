using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Gadget
{
    class TeamConfig
    {
        public string Name { get; set; }

        public int ChrType { get; set; }

        public int TeamType { get; set; }

        public TeamConfig(string name, int chrType, int teamType)
        {
            Name = name;
            ChrType = chrType;
            TeamType = teamType;
        }

    }
}
