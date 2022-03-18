using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TVShowsCatalog.Models;

namespace TVShowsCatalog.Data
{
    public class TVShowsCatalogContext : DbContext
    {
        public TVShowsCatalogContext (DbContextOptions<TVShowsCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<TVShowsCatalog.Models.TvShow> TvShow { get; set; }
    }
}
