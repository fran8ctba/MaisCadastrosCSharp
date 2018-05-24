using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UI.Web.Models
{
    public class UIWebContext : DbContext
    {
        public UIWebContext (DbContextOptions<UIWebContext> options)
            : base(options)
        {
        }

        public DbSet<UI.Web.Models.Cliente> Cliente { get; set; }
    }
}
