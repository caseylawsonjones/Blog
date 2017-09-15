using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models {
    public class Comment {

        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string MediaUrl { get; set; }
        public string UpdateReason { get; set; }
    }
}