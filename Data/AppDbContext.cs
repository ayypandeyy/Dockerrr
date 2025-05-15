﻿// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Models;

namespace SimpleWebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
