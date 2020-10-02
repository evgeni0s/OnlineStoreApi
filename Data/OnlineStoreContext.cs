using Microsoft.EntityFrameworkCore;
using OnlineStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreApi.Data
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
