using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Zed.Service.Models
{
    [Serializable]
    public sealed class redditChildrenDataItem
    {
        [XmlElement("domain")]
        public string Domain { get; set; }

        [XmlElement("banned_by")]
        public string BannedBy { get; set; }

        [XmlElement("media_embed")]
        public string MediaEmbed { get; set; }

        [XmlElement("selftext_html")]
        public string SelfTextHtml { get; set; }

        [XmlElement("selftext")]
        public string SelfText { get; set; }

        [XmlElement("likes")]
        public string Likes { get; set; }

        [XmlElement("link_flair_text")]
        public string LinkFlairText { get; set; }

        [XmlElement("id")]
        public string ID { get; set; }

        [XmlElement("clicked")]
        public string Clicked { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("num_comments")]
        public string NumberComments { get; set; }

        [XmlElement("score")]
        public string Score { get; set; }

        [XmlElement("approved_by")]
        public string ApprovedBy { get; set; }

        [XmlElement("over_18")]
        public string Over18 { get; set; }

        [XmlElement("hidden")]
        public string isHidden { get; set; }

        [XmlElement("thumbnail")]
        public string Thumbnail { get; set; }

        [XmlElement("subreddit_id")]
        public string SubRedditID { get; set; }

        [XmlElement("subreddit")]
        public string SubReddit { get; set; }

        [XmlElement("edited")]
        public string Edited { get; set; }

        [XmlElement("link_flair_css_class")]
        public string LinkFlairCssClass { get; set; }

        [XmlElement("author_flair_css_class")]
        public string AuthorFlairCssClass { get; set; }

        [XmlElement("downs")]
        public string DownVotes { get; set; }

        [XmlElement("saved")]
        public string Saved { get; set; }

        [XmlElement("is_self")]
        public string isSelf { get; set; }

        [XmlElement("permalink")]
        public string Permalink { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("created")]
        public string Created { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("author_flair_text")]
        public string AuthorFlairText { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("created_utc")]
        public string CreatedUtc { get; set; }

        [XmlElement("media")]
        public string Media { get; set; }

        [XmlElement("num_reports")]
        public string NumberReports { get; set; }

        [XmlElement("ups")]
        public string UpVotes { get; set; }

    }

    [Serializable]
    public sealed class redditChildren
    {
        [XmlElement("data")]
        public redditChildrenDataItem ChildrenData { get; set; }

        [XmlElement("kind")]
        public string Kind { get; set; }
    }

    [Serializable]
    public class redditData
    {
        [XmlElement("modhash")]
        public string ModHash { get; set; }

        [XmlElement("children")]
        public List<redditChildren> Children { get; set; }

        [XmlElement("before")]
        public string Before { get; set; }

        [XmlElement("after")]
        public string After { get; set; }
    }

    [Serializable]
    [XmlRoot("xml")]
    public class redditRss
    {
        [XmlElement("kind")]
        public string RedditKind { get; set; }

        [XmlElement("data")]
        public redditData SubReddits { get; set; }

        [XmlElement("error")]
        public string Error { get; set; }
    }
}
