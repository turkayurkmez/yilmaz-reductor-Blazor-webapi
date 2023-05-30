using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleTaskManager.Shared;

namespace SimpleTaskManager.Server.Data
{
    public class SimpleTaskManagerServerContext : DbContext
    {
        public SimpleTaskManagerServerContext (DbContextOptions<SimpleTaskManagerServerContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleTaskManager.Shared.TaskItem> TaskItem { get; set; } = default!;
    }
}
