using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BloodBowlManager.Objects
{
    class Player
    {
        public Positional Position { get; private set; }
        public string Name { get; private set; }
        public int Jersey { get; private set; }
        public int SPP { get; set; }
        public int MA { get; set; }
        public int ST { get; set; }
        public int AG { get; set; }
        public int AV { get; set; }
        public int Cost { get; set; }
        public string[] Skills { set; get; }

        public Player(string name, Positional position, int jersey)
        {
            Position = position;
            Name = name;
            Jersey = jersey;
            MA = position.MA;
            ST = position.ST;
            AG = position.AG;
            AV = position.AV;
            SPP = 0;
            Cost = position.Cost;
            if (position.Skills != null)
            {
                List<string> skilllista = new List<string>();
                foreach (string skill in position.Skills)
                {
                    skilllista.Add(skill);
                }
                Skills = skilllista.ToArray();
            }
            else Skills = new string[0];
        }
        public string ToString()
        {
            return Name + " the " + Position.Race + " " + Position.Name;
        }
    }
}
