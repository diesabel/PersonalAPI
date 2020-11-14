using System;
using Microsoft.EntityFrameworkCore;
using PersonalAPI.Models;

namespace PersonalAPI.Context
{
    public class PersonalContext : DbContext 
    {
        public PersonalContext(DbContextOptions options) : base(options) { }


        public DbSet<PasswordManager> PasswordManager { get; set; }



    }
}
