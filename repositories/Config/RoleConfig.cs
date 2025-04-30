using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElsiumCa.Repositories.Config
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Family", NormalizedName = "FAMİLY" },
                new IdentityRole { Name = "School", NormalizedName = "SCHOOL" },
                new IdentityRole { Name = "Friend", NormalizedName = "Friend" },
                new IdentityRole { Name = "Citizen" , NormalizedName = "CITIZEN"},
                new IdentityRole { Name = "President" , NormalizedName = "PRESİDENT"},
                new IdentityRole { Name = "Finance" , NormalizedName = "FİNANCE"}
                );
        
        }
    }
}