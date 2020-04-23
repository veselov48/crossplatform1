using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace veselov.Models
{
    public class WorkerContext : DbContext
    {
        public WorkerContext(DbContextOptions<WorkerContext> options)
            : base(options)
        {
        }

        public DbSet<Worker> Workers { get; set; }
    }
}