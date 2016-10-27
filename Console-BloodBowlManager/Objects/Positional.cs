using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BloodBowlManager.Objects
{
    class Positional
    {
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string[] Skills { get; private set; }
        public int Cost { get; private set; }
        public int ST { get; private set; }
        public int AG { get; private set; }
        public int MA { get; private set; }
        public int AV { get; private set; }
        public string[] NormalRoll { get; private set; }
        public string[] DoubleRoll { get; private set; }

        public Positional (string name, string race, string[] skills, int cost, int ma, int st, int ag, int av, string[] normals, string[] doubles)
        {
            Name = name;
            Race = race;
            Skills = skills;
            Cost = cost;
            MA = ma;
            ST = st;
            AG = ag;
            AV = av;
            NormalRoll = normals;
            DoubleRoll = doubles;
        }
        
        public static Positional GetPositional(string race, string position)
        {
            switch (race)
	        {
                case "Human":
                    switch (position)
	                {
                        case "Lineman":
                            return new Positional("Lineman", "Human", new string[0], 50, 6, 3, 3, 8, new string[] { "G" }, new string[] { "A", "P", "S" });
                        case "Blitzer":
                            return new Positional("Blitzer", "Human", new string[] { "Block" }, 90, 7, 3, 3, 8, new string[] { "G", "S" }, new string[] { "A", "P" });
		                default:
                            return null;
	                }
                    
		        default:
                    return null;
	        }
        }
    }
}
