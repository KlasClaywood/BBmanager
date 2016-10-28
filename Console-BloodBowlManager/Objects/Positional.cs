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
        public int Max { get; private set; }

        public Positional (string name, string race, string[] skills, int cost, int ma, int st, int ag, int av, string[] normals, string[] doubles, int max)
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
            Max = max;
        }
        public Positional (Positional target)
        {
            this.Name = target.Name;
            this.Race = target.Race;
            this.Skills = target.Skills;
            this.Cost = target.Cost;
            this.MA = target.MA;
            this.ST = target.ST;
            this.AG = target.AG;
            this.AV = target.AV;
            this.NormalRoll = target.NormalRoll;
            this.DoubleRoll = target.DoubleRoll;
            this.Max = target.Max;
        }
        public Positional(string race, string name) : this(GetPositional(race, name))
        {
             
        }
        
        public static Positional GetPositional(string race, string position)
        {
            switch (race)
	        {
                case "Human":
                    switch (position)
	                {
                        case "Lineman":
                            return new Positional("Lineman", "Human", new string[0], 50, 6, 3, 3, 8, new string[] { "G" }, new string[] { "A", "P", "S" }, 16);
                        case "Blitzer":
                            return new Positional("Blitzer", "Human", new string[] { "Block" }, 90, 7, 3, 3, 8, new string[] { "G", "S" }, new string[] { "A", "P" }, 4);
                        case "Thrower":
                            return new Positional("Thrower", "Human", new string[] { "Sure hands", "Pass" }, 70, 6, 3, 3, 8, new string[] { "G", "P" }, new string[] { "A", "S" }, 2);
                        case "Catcher":
                            return new Positional("Catcher", "Human", new string[] { "Catch", "Dodge" }, 80, 8, 3, 3, 7, new string[] { "G", "A" }, new string[] { "P", "S" }, 4);
                        case "Ogre":
                            return new Positional("Ogre", "Human", new string[] { "Mighty Blow", "Bone-head", "Throw Team-mate", "Loner", "Thick Skull" }, 140, 5, 5, 2, 9, new string[] { "S" }, new string[] { "G", "A", "P" }, 1);
                        default:
                            return null;
	                }
                case "Orc":
                    switch (position)
                    {
                        case "Lineman":
                            return new Positional("Lineman", "Orc", new string[0], 50, 5, 3, 3, 9, new string[] { "G" }, new string[] { "A", "P", "S" }, 16);
                        case "Blitzer":
                            return new Positional("Blitzer", "Orc", new string[] {"Block"}, 50, 6, 3, 3, 9, new string[] { "G", "S" }, new string[] { "A", "P" }, 4);
                        case "Black Orc Blocker":
                            return new Positional("Black Orc Blocker", "Orc", new string[0], 80, 4, 3, 2, 9, new string[] { "G", "S" }, new string[] { "A", "P" }, 4);
                        case "Thrower":
                            return new Positional("Thrower", "Orc", new string[] { "Sure hands", "Pass" }, 70, 5, 3, 3, 8, new string[] { "G", "P" }, new string[] { "A", "S" }, 2);
                        case "Goblin":
                            return new Positional("Goblin", "Orc", new string[] { "Dodge", "Right Stuff", "Stunty" }, 40, 6, 2, 3, 7, new string[] { "A" }, new string[] { "G","P", "S" }, 4);
                        case "Troll":
                            return new Positional("Troll", "Orc", new string[] { "Mighty Blow", "Really Stupid", "Throw Team-mate", "Loner", "Regeneration", "Always Hungry" }, 110, 5, 5, 1, 9, new string[] { "S" }, new string[] { "G", "A", "P" }, 1);
                   
                        default:
                            return null;
                    }
		        default:
                    return null;
	        }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Race, Name);
        }
    }
}
