using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQActors
{
    public class Actor
    {
        public string Name { get; set; }
        public decimal TotalGross { get; set; }
        public int MovieCount { get; set; }
        public decimal AveragePerMovie { get; set; }
        public string TopMovie { get; set; }
        public decimal TopMovieGross { get; set; }

        /// <summary>
        /// Modifies so it actually supplies a list of all the properties. Returns the name of the actor, then a bunch of ternary operators to return either the value of the item or if the item doesn't have a value then return a null statement.
        /// If it's not equal to 0 return the count value, if it is equal to 0 return the null value.
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return "Name: " + Name +
                (TotalGross !=0? " Total Gross: " + TotalGross : null) +
                (MovieCount !=0? " Movie Count: " + MovieCount : null) +
                (AveragePerMovie !=0? " Average Per Movie: " + AveragePerMovie : null) +
                (TopMovie != null ? " Top Movie: " + TopMovie : null) +
                (TopMovieGross != 0 ? " Top Movie Gross: " + TopMovieGross : null) +
                "\n";
        }
    }
}
