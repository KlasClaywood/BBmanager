using System;
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


        public IEnumerator<Player> GetEnumerator()
        {
            foreach (Player player in Players)
            {
                yield return player;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(Player item)
        {
            Players.Add(item);
            TeamValue += item.Cost;
            item.TeamName = this.Name;
        }

        public void Clear()
        {
            throw new NotImplementedException();
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
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Player item)
        {
            throw new NotImplementedException();
        }
    }
}
