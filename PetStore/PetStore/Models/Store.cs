using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetStore.Models
{
    public class Store : DbContext
    {
        public Store()
            :base("DefaultConnection")
        {
        }
        public DbSet<Animal> Animals { get; set; }
    }
}
}