using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BloodBankPR.Models
{
    public partial class libraryDBContext : DbContext
    {
        public libraryDBContext()
        {
        }

        public libraryDBContext(DbContextOptions<libraryDBContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<DonationRequest> DonationRequest { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Verification> Verification { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NLDOMMU\\SQLEXPRESS;Database=libraryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId)
                              .HasName("PK_Verificationm");
                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                     entity.Property(e => e.Qnt)
                      .HasColumnType("int");
                

            });
                   
            modelBuilder.Entity<DonationRequest>(entity =>
            {
                entity.HasKey(e => e.DonatRequestionId)
                              .HasName("PK_Verificationm");           
                entity.HasOne(b => b.Book)
                .WithMany(p => p.DonationRequest)
                .HasForeignKey(b => b.BookId)
                .HasConstraintName("FK_DonationRequest_Book");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DonationRequest)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DonationRequest_User");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.LastLogin)
                    .HasColumnName("lastLogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastlogout)
                    .HasColumnName("lastlogout")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Login_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                
                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Verification>(entity =>
            {
                entity.HasKey(e => e.VerificationCodeId)
                    .HasName("PK_Verificationm");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.UserEmail).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
