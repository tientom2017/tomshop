﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    class PostCategory : Auditable
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public bool HomeFlag { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
