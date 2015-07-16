using SquaresandRectangles.Data.Models;
using System.Collections.Generic;

namespace SquaresandRectangles.Service.Models
{
    public class UniversalItem : IUniversalItem
    {
        public string VoteFunctions { get; set; } //NotImplimented, use module name instead
        public string Content { get; set; } //Typically URL of Link
        public List<IUniversalItemInfo> InfoList { get; set; } //Description, Author, Post Date, Etc
        public string PostType { get; set; }
    }
}
