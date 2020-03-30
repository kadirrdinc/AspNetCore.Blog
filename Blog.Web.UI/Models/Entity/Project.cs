using Blog.Web.UI.Models.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.UI.Models.Entity
{
    public class Project: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfFinish { get; set; }
        public string LinkToAddress { get; set; }

    }
}
