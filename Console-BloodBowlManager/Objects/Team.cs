using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_BloodBowlManager.Objects
{
    class Team : IEnumerable<Player>, ICollection<Player>
    {
        public List<Player> Players { get; set; }
        public string Name { get; private set; }
        public int TeamValue { get; private set; }
        public int ID { get; private set; }
        public int[] Color { get; private set; }
        public string PlayStyle { get; set; }

        public Team (string name, int id)
        {
            ID = id;
            Name = name;
            Players = new List<Player>();
            TeamValue = 0;
            Color = new int[] { 0, 0, 200 };
            PlayStyle = "";
        }
        public Team (string name, int id, int[] rgb)
        {
            ID = id;
            Name = name;
            Players = new List<Player>();
            TeamValue = 0;
            Color = rgb;
            PlayStyle = "";
        }

        protected Team(Team team)
        {
            // TODO: Complete member initialization
            ID = team.ID;
            Name = team.Name;
            TeamValue = team.TeamValue;
            for (int i = 0; i < 3; i += 1)
            {
                Color[i] = team.Color[i];
            }
            Players = new List<Player>();
            foreach (var player in team.Players)
            {
                Players.Add(player.Clone() as Player);

            }
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (Player player in Players)
            {
                yield return player;
            }
        }
        private IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(Player item)
        {
            Players.Add(item);
            TeamValue += item.Cost;
            item.TeamName = this.Name;
            item.Rating = RatePlayer(item);
        }

        private double RatePlayer(Player item)
        {
            double rating = 0.0;
            rating += item.MA + item.AV + item.AG*2 + item.ST*3;
            if (item.Skills.Contains("Block"))
            {
                rating += 10;
            }
            return rating;
        }

        public void Clear()
        {
            Players.Clear();
        }

        public bool Contains(Player item)
        {
            return Players.Contains(item);
        }

        public void CopyTo(Player[] array, int arrayIndex)
        {
            Players.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Players.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Player item)
        {
            return Players.Remove(item);
        }

        public object Clone()
        {
            return new Team(this);
        }

        public object[] getActivePlayers()
        {

            var query = Players.OrderBy(p => p.Rating).Take(11).ToArray();
            return query;
        }
    }
}
