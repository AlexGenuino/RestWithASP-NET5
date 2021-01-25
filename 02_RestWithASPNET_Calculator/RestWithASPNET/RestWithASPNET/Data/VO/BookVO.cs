using RestWithASPNET.Hypermedia;
using RestWithASPNET.Hypermedia.Abstract;
using RestWithASPNET.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Data.VO
{
   
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        
        public string Author { get; set; }

        
        public DateTime LaunchDate { get; set; }
        
        
        public decimal Price { get; set;}
        
       
        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
