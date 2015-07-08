﻿using System.Collections.Generic;

namespace Zed.Service.Models
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