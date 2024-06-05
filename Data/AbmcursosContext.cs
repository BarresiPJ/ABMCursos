using System;
using System.Collections.Generic;
using ABMCursos.Models;
using Microsoft.EntityFrameworkCore;

namespace ABMCursos.Data;

public partial class AbmcursosContext : DbContext
{
    public AbmcursosContext()
    {
    }

    public AbmcursosContext(DbContextOptions<AbmcursosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curso> Cursos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Idcurso).HasName("PK__CURSO__91D9FD32636C22D3");

            entity.ToTable("CURSO");

            entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");
            entity.Property(e => e.Cantidadalumnos).HasColumnName("CANTIDADALUMNOS");
            entity.Property(e => e.Dia)
                .HasMaxLength(10)
                .HasColumnName("DIA");
            entity.Property(e => e.Horario).HasColumnName("HORARIO");
            entity.Property(e => e.Nombrecurso)
                .HasMaxLength(100)
                .HasColumnName("NOMBRECURSO");
            entity.Property(e => e.Profesor)
                .HasMaxLength(100)
                .HasColumnName("PROFESOR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
