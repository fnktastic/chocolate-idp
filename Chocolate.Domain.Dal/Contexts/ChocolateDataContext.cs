using Chocolate.Domain.Core.Entities;
using Chocolate.Domain.Dal.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate.Domain.Dal.Contexts
{
    public class ChocolateDataContext : DbContext
    {
        private readonly string _schema = "choco";
        private readonly string _conn;

        public DbSet<ChocolateEntity> ChocolateEntities { get; set; }

        public ChocolateDataContext(DbContextOptions options) : base(options)
        {

        }

        public ChocolateDataContext(string conn) :base()
        {
            _conn = conn;
        }

        public ChocolateDataContext()
        {
            _conn = @"Server=.\;initial catalog=chocolate;persist security info=True;Integrated Security=true;Connection Timeout=30;MultipleActiveResultSets=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(_conn,
                    x => x.MigrationsHistoryTable("__MigrationsHistory", _schema));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChocolateContextConfiguration());
            modelBuilder.HasDefaultSchema(_schema);
            base.OnModelCreating(modelBuilder);
        }
    }
}
