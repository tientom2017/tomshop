﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        public string TagID { get; set; }
    }
}
