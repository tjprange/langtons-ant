using System;
using Microsoft.EntityFrameworkCore;

namespace server.Models;

public class AntDbContext : DbContext
{
    public AntDbContext(DbContextOptions<AntDbContext> options)
        : base(options)
    {
    }
}
