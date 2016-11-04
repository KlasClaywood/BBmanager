using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_BloodBowlManager.Objects;

namespace Console_BloodBowlManager.Matches
{
    class Match :ICloneable
    {
        private int NUMBEROFTURNS = 16;
        private int homeScore;
        private int awayScore;
        public Team HomeTeam { private set; get; }
        public Team AwayTeam { private set; get; }
        private List<Player> activePlayers;
        private Random RND;

        public Match (Team homeTeam, Team awayTeam)
        {
            RND = new Random();
            HomeTeam = homeTeam;
        }
        protected Match (Match another)
        {

        }
        public Highlight[] Highlights { private set; get; }

        public Highlight[] RunMatch(Team HomeTeam, Team AwayTeam)
        {
            for (int turn = 1; turn <= NUMBEROFTURNS; turn += 1)
            {
                
            }
        }

        public object Clone()
        {
            return new Match(this);
        }
    }
}
