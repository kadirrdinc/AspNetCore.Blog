using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime EditDate { get; set; }

    }
}
