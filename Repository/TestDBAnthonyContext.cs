using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DeveloperTest_Anthony_Mugabira
{
    public partial class TestDBAnthonyContext : DbContext
    {
        public TestDBAnthonyContext()
        {
        }

        public TestDBAnthonyContext(DbContextOptions<TestDBAnthonyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientGroup> ClientGroup { get; set; }
        public virtual DbSet<ClientGroupUsers> ClientGroupUsers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        
           string connStringEmb = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\MULLE\SOURCE\REPOS\DEVELOPERTEST_ANTHONY_MUGABIRA\REPOSITORY\DATABASE\ANTHONYDBTEST.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           // string connString = "Server=DESKTOP-T0D9UFN\\SQLEXPRESS;Initial Catalog=TestDBAnthony;Persist Security Info=True;User ID=anthony;Password=123456;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connStringEmb);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientGroup>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ClientGroupUsers>(entity =>
            {
                entity.HasOne(d => d.ClientGroup)
                    .WithMany(p => p.ClientGroupUsers)
                    .HasForeignKey(d => d.ClientGroupId)
                    .HasConstraintName("FK_ClientGroup_ClientGroupUsers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClientGroupUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Users_ClientGroupUsers");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
