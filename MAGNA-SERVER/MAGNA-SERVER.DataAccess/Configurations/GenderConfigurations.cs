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
    internal class GenderConfigurations : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> entity)
        {

            entity.ToTable("Gender");

            entity.HasKey(g => g.Id);

            entity.Property(g => g.Id)
                .HasColumnName("GenderId")
                .HasColumnType("int")
                .ValueGeneratedNever();

            entity.Property(g => g.GenderDescription)
                .IsRequired()
                .HasColumnName("GenderDescription")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(g => g.GenderState)
                .HasColumnName("GenderState")
                .HasDefaultValue(0)
                .HasColumnType("int");


        }
    }
}
