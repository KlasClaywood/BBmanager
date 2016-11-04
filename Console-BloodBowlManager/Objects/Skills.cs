using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BloodBowlManager.Objects
{
    class Skill:IEquatable<Skill>
    {
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public double Rating { get; protected set; }
        public static Skill BLOCK { }
        public Skill (string name, string cat, double rat)
        {
            Name = name;
            Category = cat;
            Rating = rat;
        }

        public bool Equals(Skill other)
        {
            return Name == other.Name;
        }
        
    }
}
