using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeywords { get; set; }
        string MetaDescriptions { get; set; }

        string ModififiedDate { set; get; }
        string ModifiedBy { set; get; }

        bool Status { set; get; }
    }
}
