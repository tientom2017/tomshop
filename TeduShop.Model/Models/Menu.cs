﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        public string Target { get; set; }

        public bool Status { get; set; }
    }
}