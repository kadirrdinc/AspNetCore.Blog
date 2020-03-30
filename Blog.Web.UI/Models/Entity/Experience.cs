using Blog.Web.UI.Models.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity
{
    public class Experience : BaseEntity
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfStart { get; set; }
        public string DateOfFinish { get; set; }
        public bool Status { get; set; }

    }
}
