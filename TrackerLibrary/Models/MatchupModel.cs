
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// This stores the list of teams involved a stage
        /// of the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// This stores the winning team
        /// </summary>
        public TeamModel? Winner { get; set; }

        /// <summary>
        /// This shows the round of the tournament
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
