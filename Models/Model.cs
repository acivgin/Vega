namespace vega.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation property
        public Make Make { get; set; }

        //Foreign key Property
        public int MakeId { get; set; }
    }
}