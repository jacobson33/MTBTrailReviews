using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MTBTrailReviews.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public int TrailID { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }

    }
}