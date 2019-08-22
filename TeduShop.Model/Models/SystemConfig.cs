﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    class SystemConfig
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string Code { get; set; }

        public string ValueString { get; set; }

        public int ValueInt { get; set; }
    }
}
