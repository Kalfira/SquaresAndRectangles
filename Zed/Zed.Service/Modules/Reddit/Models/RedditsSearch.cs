using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Zed.Service.Modules.Reddit.Models
{
    [Serializable]
    public class redditsSearchItem
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("guid")]
        public string Guid { get; set; }

        [XmlElement("dc:date")]
        public string PublishDate { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }


    [Serializable]
    public class redditsSearchChannel
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }



        [XmlElement("item")]
        public List<redditsSearchItem> item { get; set; }
    }


    [Serializable]
    [XmlRoot("rss")]
    public class redditsSearch
    {
        [XmlElement("channel")]
        public redditsSearchChannel channel { get; set; }
    }
}
