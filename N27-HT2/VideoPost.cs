using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT2
{
    public class VideoPost
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Topics topic { get; set; }
    }
}
