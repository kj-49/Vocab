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
                Id = Guid.NewGuid(),
                Name = "Master",
                NormalizedName = "MASTER"
            },
            new AppRole
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new AppRole
            {
                Id = Guid.NewGuid(),
                Name = "Client",
                NormalizedName = "CLIENT"
            }
        );
    }
}
