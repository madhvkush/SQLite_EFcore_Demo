using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_EFCore.DAL
{
    internal class SQLite_EFCore_Context : DbContext
    {
        private static bool _created = false;
        public SQLite_EFCore_Context()
        {
            if (!_created) // These logics only for Staging enviornment.
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=SQLiteDemo.db;"); // It will create DB - SQLiteDemo.db in same .exe foler
        }

        public DbSet<Entities.Person> Persons { get; set; }
    }
}
