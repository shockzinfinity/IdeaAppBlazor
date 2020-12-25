using System;
using IdeaAppBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace IdeaAppBlazor
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Idea> Ideas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=idea.db");
    }
}
