using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This is the position a team ends up in
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// This stores a name given to the position
        /// </summary>
        /// <example>
        /// The first position is called the winner or the champion
        /// </example>
        public string? PlaceName { get; set; }

        /// <summary>
        /// This is the amount of money a team goes home with 
        /// if it ends up in a position which could be awarded
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// This stores a percentage of the tournamen earnings a 
        /// specific team wins
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0.0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
