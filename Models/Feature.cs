using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    public class Feature
    {
      [Key]
      [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
       public string Name { get; set; }
    }
}