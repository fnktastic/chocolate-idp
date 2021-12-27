using Chocolate.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate.Domain.Dal.Configurations
{
    public class ChocolateContextConfiguration : IEntityTypeConfiguration<ChocolateEntity>
    {
        public void Configure(EntityTypeBuilder<ChocolateEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("ChocolateEntities");
        }
    }
}
