using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CRUD_1.Models
{
    public class contextocs: DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        
    }
}