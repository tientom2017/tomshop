using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeywords { get; set; }

        [MaxLength(256)]
        public string MetaDescriptions { get; set; }

        [MaxLength(100)]
        public string ModififiedDate { set; get; }

        [MaxLength(256)]
        public string ModifiedBy { set; get; }

        public bool Status { set; get; }
    }
}
