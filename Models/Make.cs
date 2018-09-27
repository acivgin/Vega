using System.Collections.Generic;
        
namespace vega.Models
{
    public class Make
    {
        public Make()
        {
            Models = new List<Model>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IList<Model> Models { get; set; }
    }
}