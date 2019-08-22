using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatics")]
    class VisitorStatic
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string VisitedDate { get; set; }

        public string IPAddress { get; set; }
    }
}
