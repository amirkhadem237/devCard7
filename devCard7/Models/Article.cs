using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devCard7.Models
{
    public class Article
    {
        public long id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string discription { get; set; }

        public Article(long id, string title, string discription, string image)
        {
            this.id = id;
            this.title = title;
            this.discription = discription;
            this.image = image;
        }
    }
}
