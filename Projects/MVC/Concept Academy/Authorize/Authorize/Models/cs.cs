using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Authorize.Models
{
    
    public class cs : DbContext
    {
        public DbSet<signup> Signups { get; set; }
    }
}