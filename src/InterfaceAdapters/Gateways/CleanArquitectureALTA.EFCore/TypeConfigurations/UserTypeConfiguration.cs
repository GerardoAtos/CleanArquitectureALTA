using Alta.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.EFCore.TypeConfigurations
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.CreationDate).HasDefaultValueSql("getdate()");
            builder.Property(x => x.Comment).HasColumnType("varchar(200)");



        }
    }
}
