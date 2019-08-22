using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface ISeoable
    {
        string MetaKeywords { get; set; }
        string MetaDescriptions { get; set; }
    }
}
