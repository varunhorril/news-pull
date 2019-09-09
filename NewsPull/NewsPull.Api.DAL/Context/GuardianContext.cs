using Microsoft.EntityFrameworkCore;
using NewsPull.Api.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.DAL.Context
{
    public class GuardianContext : DbContext
    {
        public GuardianContext(DbContextOptions<GuardianContext> options): base(options)
        {

        }

        public DbSet<Subscriber> Subscribers { get; set; }

    }
}
