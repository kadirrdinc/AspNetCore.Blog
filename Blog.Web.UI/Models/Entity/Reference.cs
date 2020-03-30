using Blog.Web.UI.Models.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity
{
    public class Reference: BaseEntity
    {
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
    }
}
