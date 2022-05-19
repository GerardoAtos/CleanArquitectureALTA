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
    public class HeartbeatInitiateTypeConfiguration : IEntityTypeConfiguration<HeartbeatInitiate>
    {
        public void Configure(EntityTypeBuilder<HeartbeatInitiate> builder)
        {
            builder.ToTable("HeartbeatInitiate");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TranId).HasColumnType("varchar(25)");
            builder.Property(x => x.TranDT).HasColumnType("varchar(20)");
            builder.Property(x => x.WHId).HasColumnType("varchar(10)");
            builder.Property(x => x.WCSId).HasColumnType("varchar(10)");
            builder.Property(x => x.Text).HasColumnType("varchar(50)");
            builder.Property(x => x.MessageReceived).HasColumnType("varchar(MAX)");
            builder.Property(x => x.CreationDatetime).HasDefaultValueSql("getdate()").IsRequired(true);
        }
    }
}
