using MAGNA_SERVER.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_SERVER.DataAccess.Configurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {

            entity.ToTable("Employee");

            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Id)
                .HasColumnName("EmployeeId")
                .HasColumnType("int")
                .ValueGeneratedNever();

            entity.Property(e => e.EmployeeCode)
                .IsRequired()
                .HasColumnName("EmployeeCode")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EmployeeFirstName)
                .IsRequired()
                .HasColumnName("EmployeeFirstName")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmployeeLastName)
                .IsRequired()
                .HasColumnName("EmployeeLastName")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsUnicode(false);

             entity.Property(e => e.EmployeeAddress)
                .IsRequired()
                .HasColumnName("EmployeeAddress")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsUnicode(false);

             entity.Property(e => e.EmployeeCountry)
                .IsRequired()
                .HasColumnName("EmployeeCountry")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsUnicode(false);

             entity.Property(e => e.EmployeeCity)
                .IsRequired()
                .HasColumnName("EmployeeCity")
                .HasColumnType("varchar")
                .HasMaxLength(150)
                .IsUnicode(false);


             entity.Property(e => e.EmployeeEmailAddress)
               .IsRequired()
               .HasColumnName("EmployeeEmailAddress")
               .HasMaxLength(200)
               .HasColumnType("varchar")
               .IsUnicode(false);
    
             entity.Property(e => e.EmployeePhoneNumber)
               .IsRequired()
               .HasColumnName("EmployeePhoneNumber")
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsUnicode(false);
            
             entity.Property(e => e.EmployeeBirthday)
                .HasColumnName("EmployeeBirthday")
                .HasColumnType("datetime");

             entity.Property(e => e.EmployeeStartDate)
                .IsRequired()
                .HasColumnName("EmployeeStartDate")
                .HasColumnType("datetime");

             entity.Property(e => e.EmployeeEndDate)
                .HasColumnName("EmployeeEndDate")
                .HasColumnType("datetime");

            entity.Property(e => e.EmployeeState)
                .HasColumnName("EmployeeState")
                .HasDefaultValue(0)
                .HasColumnType("int");


            //entity.Property(e => e.EmployeePhotoUrl)
            //    .HasColumnName("EmployeePhotoUrl")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(150);

            //entity.HasOne(g => g.Gender)
            //    .WithMany()
            //    .HasForeignKey(g => g.GenderId)
            //    .HasConstraintName("GenderId");
        }
    }
}
