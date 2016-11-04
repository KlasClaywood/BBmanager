using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BloodBowlManager.Objects
{
    class StarPlayer : Player, ICloneable
    {
        

        public StarPlayer(string name, Positional position, int jersey)
            : base(name, position, jersey)
        {
            
            MA = position.MA +1;
            ST = position.ST +1;
            AG = position.AG +1;
            AV = position.AV +1;
            SPP = 120;
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

        protected StarPlayer(StarPlayer player) :base (player.Name, player.Position, player.Jersey)
        {

            // TODO: Complete member initialization
            MA = player.Position.MA + 1;
            ST = player.Position.ST + 1;
            AG = player.Position.AG + 1;
            AV = player.Position.AV + 1;
            SPP = 120;
            Cost = player.Position.Cost;
            if (player.Skills != null)
            {
                List<string> skilllista = new List<string>();
                foreach (string skill in player.Skills)
                {
                    skilllista.Add(skill);
                }
                Skills = skilllista.ToArray();
            }
            else Skills = new string[0];
       
        }
        public override string ToString()
        {
            return string.Format("TeamName:{0};Position:{1};Name:{2};Jersey:{3};MA:{4};ST:{5};AG:{6};AV:{7};SPP:{8};Skills:{9};Cost:{10}",
                                  TeamName,    Position,    Name,    Jersey,    MA,    ST,    AG,    AV,    SPP, this.GetSkillsString(),    Cost);
        }

        private string GetSkillsString()
        {
            string svar = "";
            foreach (string skill in Skills)
            {
                svar+= skill + ",";
            }
            return svar.TrimEnd(',');
        }

        public StarPlayer Clone()
        {
            return new StarPlayer(this);
        }

        public object Clone()
        {
            return new StarPlayer(this.Name, this.Position, this.Jersey, );
        }

       
    }
}
