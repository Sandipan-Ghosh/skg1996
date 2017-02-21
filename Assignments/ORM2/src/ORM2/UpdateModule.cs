using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ORM2
{
    public class UpdateModel
    {
        [Key]
        [MaxLength(5)]
        public int UpdateId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength (50)]
        public string Description { get; set; }
        public int Id { get; set; }
        [ForeignKey("Id")]
        public ProductModel ProductModels { get; set; }

    }
}
