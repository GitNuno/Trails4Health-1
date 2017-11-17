using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Trails4Health.Models
{
    public partial class Trails4HealthContext : DbContext
    {
        public virtual DbSet<Trails> Trails { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Questions> Questions { get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TrailsName).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-mail");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<Questions>(entity => {
                entity.Property(e => e.QuestionID).HasColumnName("QuestionID");

                entity.Property(e => e.Question)
                .IsRequired()
                .HasColumnName("Question");

                entity.Property(e => e.QuestionDate).HasColumnName("QuestionDate");
            });
        }
    }
}