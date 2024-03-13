using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
       public void Configure (EntityTypeBuilder<Plane> builder)
        {
            builder.HasMany(e => e.Flights).WithOne(e => e.Plane).
                OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
