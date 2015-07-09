using System.Collections.Generic;

namespace SquaresandRectangles.Service.Models
{
    public class UniversalReport
    {
        public IList<UniversalItem> UniversalItems { get; set; }

        public UniversalReport()
        {
            UniversalItems = new List<UniversalItem>();
        }
    }
}