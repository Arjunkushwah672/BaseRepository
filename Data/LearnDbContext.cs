using System;
using System.Collections.Generic;
using BaseRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseRepository.Data;

public partial class LearnDbContext : DbContext
{
    public LearnDbContext()
    {
    }

    public LearnDbContext(DbContextOptions<LearnDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MstRegistration> MstRegistrations { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-42PDD4C\\SQLEXPRESS;Database=LearnDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
