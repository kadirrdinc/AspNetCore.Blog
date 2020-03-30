using Blog.Web.UI.Models.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity
{
    public class Education:BaseEntity
    {
        public string SchoolName { get; set; }
        public string SectionName { get; set; }
        public DateTime DateOfStart { get; set; }
        public string DateOfFinish { get; set; }
        public bool Status { get; set; }

    }
}
