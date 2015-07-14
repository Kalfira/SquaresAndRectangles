using SquaresandRectangles.Service.Models;
using SquaresandRectangles.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SquaresandRectangles.Api.Controllers
{
    public class CommentController : ApiController
    {
        RedditCommentServ _comment = new RedditCommentServ();

        //public string GetComment()
        //{
        //    return "No Comments.";
        //}
        [HttpPost]
        public UniversalReport GetComment([FromBody]string perma)
        {
            var results = _comment.GetComments(perma);

            return results;
        }
    }
}
