using Blog.Web.UI.Models.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity
{
    public class About: BaseEntity
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
