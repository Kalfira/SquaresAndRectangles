using System.Collections.Generic;

namespace Zed.Service.Models
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