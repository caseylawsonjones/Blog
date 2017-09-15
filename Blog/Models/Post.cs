using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models {
    public class Post {
    
        public Post() {
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set;}
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string MediaUrl { get; set; }
        public bool Published { get; set; }
        public string Slug { get; set; }

        public virtual ApplicationUser Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        //public virtual ICollection<Reaction> Reactions { get; set; }


   }






}