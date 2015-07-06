using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zed.Domain.Models
{
    public class RedditDemo
    {
        public RedditData data { get; set; }
    }

    public class RedditData
    {
        public IList<RedditChildren> children { get; set; }
    }

    public class RedditChildren
    {
        public string name { get; set; }
        public IList<string> mod_permissions { get; set; }
    }
}
