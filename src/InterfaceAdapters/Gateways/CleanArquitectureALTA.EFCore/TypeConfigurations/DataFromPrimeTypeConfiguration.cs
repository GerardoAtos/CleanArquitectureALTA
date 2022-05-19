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
    public class DataFromPrimeTypeConfiguration : IEntityTypeConfiguration<DataFromPrime>
    {
        public void Configure(EntityTypeBuilder<DataFromPrime> builder)
        {
            builder.ToTable("DataFromPrime");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TranId).HasColumnType("varchar(25)");
            builder.Property(x => x.Data).HasColumnType("varchar(MAX)");
            builder.Property(x => x.Endpoint).HasColumnType("varchar(50)");
            builder.Property(x => x.Application).HasColumnType("varchar(50)");
            builder.Property(x => x.Date).HasDefaultValueSql("getdate()");
        }
    }
}
