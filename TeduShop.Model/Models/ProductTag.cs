using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    class ProductTag
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        public string TagID { get; set; }
    }
}
