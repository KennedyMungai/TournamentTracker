using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// This is the name of the tournament
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// This is the amount of money a team should pay to participate
        /// in a tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// This is the list of the teams partcipating in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// This is a list of all the prizes up for grabs
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// This is the number of rounds that the tournament should take 
        /// before it is done
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
