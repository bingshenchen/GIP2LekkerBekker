using System;
using System.Collections.Generic;
using LekkerBek.Models;
using Microsoft.EntityFrameworkCore;

namespace LekkerBek.Data;

public partial class DataLekkerBekContext : DbContext
{
    public DataLekkerBekContext()
    {
    }

    public DataLekkerBekContext(DbContextOptions<DataLekkerBekContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ucllgip14sql.database.windows.net;Database=dataLekkerBek;User Id=bingshen.chen;Password=sky123cbs.;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<LekkerBek.Models.Order>? Order { get; set; }

    public DbSet<LekkerBek.Models.Recipe>? Recipe { get; set; }
}
