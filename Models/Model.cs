using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("Models")]
    public class Model
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        //Navigation property
        public Make Make { get; set; }

        //Foreign key Property
        public int MakeId { get; set; }
    }
}