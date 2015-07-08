using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zed.Service.Models
{
    public class UniversalItem
    {
        public string VoteFunctions { get; set; } //NotImplimented, use module name instead
        public string Content { get; set; } //Typically URL of Link
        public IList<string> InfoList { get; set; } //Description, Author, Post Date, Etc
    }
}
