using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("Makes")]
    public class Make
    {
        public Make()
        {
            Models = new List<Model>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
        
        public IList<Model> Models { get; set; }
    }
}