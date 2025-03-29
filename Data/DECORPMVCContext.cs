using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DECORPMVC.Models;

namespace DECORPMVC.Data
{
    public class DECORPMVCContext : DbContext
    {
        public DECORPMVCContext (DbContextOptions<DECORPMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DECORPMVC.Models.Departament> Departament { get; set; }
    }
}
