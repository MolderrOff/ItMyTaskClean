using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMyTaskClean.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItMyTaskClean.Infrastructure.Persistens.EntityConfigurations;

internal class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(b => b.NameTask)
            .IsRequired();
        builder.Property(b => b.TaskNumber)
            .IsRequired();
        builder.Property(b => b.Description)
            .IsRequired();
        builder.Property(b => b.Customer)
            .IsRequired();
        builder.Property(b => b.AdressTask)
            .IsRequired();
        builder.Property(b => b.Price)
            .IsRequired();
    }
}
