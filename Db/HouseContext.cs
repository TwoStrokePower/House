using HouseClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
   
    
        public class HouseContext : DbContext
        {
            public HouseContext()
                : base("DbConnection")
            { }
            public DbSet<House> Houses => Set<House>();

        public void Save()
        {
            SaveChanges();
        }
       
        }

        
    }

