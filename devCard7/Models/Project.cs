using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devCard7.Models
{
    public class Project
    {
        public long id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string client { get; set; }

        public Project(long id, string image, string title, string description, string client)
        {
            this.id = id;
            this.image = image;
            this.title = title;
            this.description = description;
            this.client = client;
        }
    }
}
