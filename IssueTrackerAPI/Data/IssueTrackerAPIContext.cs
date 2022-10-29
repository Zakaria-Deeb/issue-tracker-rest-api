using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IssueTrackerAPI.Models;

namespace IssueTrackerAPI.Data
{
    public class IssueTrackerAPIContext : DbContext
    {
        public IssueTrackerAPIContext (DbContextOptions<IssueTrackerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<IssueTrackerAPI.Models.Issue> Issue { get; set; } = default!;
    }
}
