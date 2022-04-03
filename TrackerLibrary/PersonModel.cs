using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// The first name
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Email address to send news to the person
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        public string? CellhoneNumber { get; set; }
    }
}
