﻿using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;


namespace SchoolMusic.Web.Data
{
    public class SchoolMusicWebContext : DbContext
    {
        public SchoolMusicWebContext(DbContextOptions<SchoolMusicWebContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cursada>()
                .HasOne(c => c.Course)
                .WithOne(c => c.Cursada)
                .HasForeignKey<Cursada>(c => c.IdCourse)
                .IsRequired();
            modelBuilder.Entity<Cursada>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.Cursada)  // Un Teacher tiene muchas Cursadas
                .HasForeignKey(t => t.IdTeacher)
                .IsRequired();
        }

        public DbSet<SchoolMusic.Entidades.Course> Course { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Cursada> Cursada { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Users> Users { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Teacher> Teacher { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Student> Student { get; set; } = default!;
    }
}
