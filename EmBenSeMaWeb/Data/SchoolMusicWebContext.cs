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
                .HasOne(c => c.Course)            // Relación uno a muchos: una Cursada tiene un Course
                .WithMany(c => c.Cursadas)        // Un Course tiene muchas Cursadas
                .HasForeignKey(c => c.IdCourse)   // La FK en Cursada es IdCourse
                .IsRequired();

            modelBuilder.Entity<Cursada>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.Cursada)  // Un Teacher tiene muchas Cursadas
                .HasForeignKey(t => t.IdTeacher)
                .IsRequired();

            // Relación uno a muchos entre Student e Inscription
            modelBuilder.Entity<Inscription>()
                .HasOne(i => i.Student)
                .WithMany(s => s.Inscriptions)
                .HasForeignKey(i => i.idStudent)
                .IsRequired();

            // Relación uno a muchos entre Cursada e Inscription
            modelBuilder.Entity<Inscription>()
                .HasOne(i => i.Cursada)
                .WithMany(c => c.Inscriptions)
                .HasForeignKey(i => i.idCursada)
                .IsRequired();

            // Relación uno a muchos entre Tpoic e Coment
            modelBuilder.Entity<Coment>()
                .HasOne(t => t.Topic)
                .WithMany(c => c.Coments)
                .HasForeignKey(i => i.IdTopic)
                .IsRequired();

            // Relación uno a uno entre Teacher e User
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Users) // Un Teacher tiene un User
                .WithOne(u => u.Teacher) // Un User tiene un Teacher
                .HasForeignKey<Teacher>(t => t.IdUser) // Clave foránea en Teacher
                .IsRequired(); // Relación obligatoria

            // Relación uno a uno entre Student e User
            modelBuilder.Entity<Student>()
                .HasOne(t => t.Users) // Un Student tiene un User
                .WithOne(u => u.Student) // Un User tiene un Student
                .HasForeignKey<Student>(t => t.IdUser) // Clave foránea en Student
                .IsRequired(); // Relación obligatoria

        }

        public DbSet<SchoolMusic.Entidades.Course> Course { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Cursada> Cursada { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Users> Users { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Teacher> Teacher { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Student> Student { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Inscription> Inscription { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Notification> Notification { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Topic> Topic { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Coment> Coment { get; set; } = default!;

        public DbSet<SchoolMusic.Entidades.Assitance> Assitance { get; set; } = default!;
    }
}
