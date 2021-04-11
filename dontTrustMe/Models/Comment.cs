using System;

namespace dontTrustMe.Models
{
    public class Comment
    {      
        public int id { get; set; }
        public string nick { get; set; }

        public string text { get; set; }

        public DateTime dt { get; set; }
    }
}