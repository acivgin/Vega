using System.Collections.Generic;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
         public MakeResource()
        {
            Models = new List<ModelResource>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public IList<ModelResource> Models { get; set; }
    }
}