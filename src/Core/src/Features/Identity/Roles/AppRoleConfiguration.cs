using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocab.Core.Features.Identity.Roles;
public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.ToTable("asp_net_roles");
        builder.HasData(
            new AppRole
            {
                Id = Guid.Parse("e25b3c02-1c9d-4adf-8b2c-91d8ab749bdb"),
                Name = "Master",
                NormalizedName = "MASTER"
            },
            new AppRole
            {
                Id = Guid.Parse("a14f6d3b-9453-41dc-bb9b-50a6c4f5b91a"),
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new AppRole
            {
                Id = Guid.Parse("d8478bd6-c2a5-4a1c-8856-2442db9c47b3"),
                Name = "Client",
                NormalizedName = "CLIENT"
            }
        );
    }
}
