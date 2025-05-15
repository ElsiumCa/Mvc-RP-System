using Entities.RpItems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ElsiumCa.Repositories.Config
{
    public class ConsConfig : IEntityTypeConfiguration<Constitution>
    {
        public void Configure(EntityTypeBuilder<Constitution> builder)
        {
            builder.HasData(
                new Constitution
                {
                    Id = 1,
                    Title = "Anayasa 1",
                    Content = "Bu, Anayasa 1'in içeriğidir.",
                    CreatedByUserId = "user1",
                    CreatedAt = DateTime.UtcNow.AddDays(-10),
                    EndsAt = DateTime.UtcNow.AddDays(-5),
                    YesVotes = 50,
                    NoVotes = 30
                },
                new Constitution
                {
                    Id = 2,
                    Title = "Anayasa 2",
                    Content = "Bu, Anayasa 2'nin içeriğidir.",
                    CreatedByUserId = "user2",
                    CreatedAt = DateTime.UtcNow.AddDays(-8),
                    EndsAt = DateTime.UtcNow.AddDays(-3),
                    YesVotes = 40,
                    NoVotes = 60
                },
                new Constitution
                {
                    Id = 3,
                    Title = "Anayasa 3",
                    Content = "Bu, Anayasa 3'ün içeriğidir.",
                    CreatedByUserId = "user3",
                    CreatedAt = DateTime.UtcNow.AddDays(-15),
                    EndsAt = DateTime.UtcNow.AddDays(-10),
                    YesVotes = 70,
                    NoVotes = 20
                },
                new Constitution
                {
                    Id = 4,
                    Title = "Anayasa 4",
                    Content = "Bu, Anayasa 4'ün içeriğidir.",
                    CreatedByUserId = "user4",
                    CreatedAt = DateTime.UtcNow.AddDays(-12),
                    EndsAt = DateTime.UtcNow.AddDays(-7),
                    YesVotes = 30,
                    NoVotes = 40
                },
                new Constitution
                {
                    Id = 5,
                    Title = "Anayasa 5",
                    Content = "Bu, Anayasa 5'in içeriğidir.",
                    CreatedByUserId = "user5",
                    CreatedAt = DateTime.UtcNow.AddDays(-20),
                    EndsAt = DateTime.UtcNow.AddDays(-15),
                    YesVotes = 90,
                    NoVotes = 10
                },
                new Constitution
                {
                    Id = 6,
                    Title = "Anayasa 6",
                    Content = "Bu, Anayasa 6'nın içeriğidir.",
                    CreatedByUserId = "user6",
                    CreatedAt = DateTime.UtcNow.AddDays(-18),
                    EndsAt = DateTime.UtcNow.AddDays(-13),
                    YesVotes = 60,
                    NoVotes = 50
                },
                new Constitution
                {
                    Id = 7,
                    Title = "Anayasa 7",
                    Content = "Bu, Anayasa 7'nin içeriğidir.",
                    CreatedByUserId = "user7",
                    CreatedAt = DateTime.UtcNow.AddDays(-25),
                    EndsAt = DateTime.UtcNow.AddDays(-20),
                    YesVotes = 80,
                    NoVotes = 40
                },
                new Constitution
                {
                    Id = 8,
                    Title = "Anayasa 8",
                    Content = "Bu, Anayasa 8'in içeriğidir.",
                    CreatedByUserId = "user8",
                    CreatedAt = DateTime.UtcNow.AddDays(-22),
                    EndsAt = DateTime.UtcNow.AddDays(-17),
                    YesVotes = 20,
                    NoVotes = 70
                },
                new Constitution
                {
                    Id = 9,
                    Title = "Anayasa 9",
                    Content = "Bu, Anayasa 9'un içeriğidir.",
                    CreatedByUserId = "user9",
                    CreatedAt = DateTime.UtcNow.AddDays(-30),
                    EndsAt = DateTime.UtcNow.AddDays(-25),
                    YesVotes = 100,
                    NoVotes = 5
                },
                new Constitution
                {
                    Id = 10,
                    Title = "Anayasa 10",
                    Content = "Bu, Anayasa 10'un içeriğidir.",
                    CreatedByUserId = "user10",
                    CreatedAt = DateTime.UtcNow.AddDays(-28),
                    EndsAt = DateTime.UtcNow.AddDays(-23),
                    YesVotes = 50,
                    NoVotes = 50
                },
                new Constitution
                {
                    Id = 11,
                    Title = "Anayasa 11",
                    Content = "Bu, Anayasa 11'in içeriğidir.",
                    CreatedByUserId = "user11",
                    CreatedAt = DateTime.UtcNow.AddDays(-35),
                    EndsAt = DateTime.UtcNow.AddDays(-30),
                    YesVotes = 60,
                    NoVotes = 30
                },
                new Constitution
                {
                    Id = 12,
                    Title = "Anayasa 12",
                    Content = "Bu, Anayasa 12'nin içeriğidir.",
                    CreatedByUserId = "user12",
                    CreatedAt = DateTime.UtcNow.AddDays(-40),
                    EndsAt = DateTime.UtcNow.AddDays(-35),
                    YesVotes = 70,
                    NoVotes = 20
                },
                new Constitution
                {
                    Id = 13,
                    Title = "Anayasa 13",
                    Content = "Bu, Anayasa 13'ün içeriğidir.",
                    CreatedByUserId = "user13",
                    CreatedAt = DateTime.UtcNow.AddDays(-45),
                    EndsAt = DateTime.UtcNow.AddDays(-40),
                    YesVotes = 30,
                    NoVotes = 60
                },
                new Constitution
                {
                    Id = 14,
                    Title = "Anayasa 14",
                    Content = "Bu, Anayasa 14'ün içeriğidir.",
                    CreatedByUserId = "user14",
                    CreatedAt = DateTime.UtcNow.AddDays(-50),
                    EndsAt = DateTime.UtcNow.AddDays(-45),
                    YesVotes = 90,
                    NoVotes = 10
                },
                new Constitution
                {
                    Id = 15,
                    Title = "Anayasa 15",
                    Content = "Bu, Anayasa 15'in içeriğidir.",
                    CreatedByUserId = "user15",
                    CreatedAt = DateTime.UtcNow.AddDays(-55),
                    EndsAt = DateTime.UtcNow.AddDays(-50),
                    YesVotes = 40,
                    NoVotes = 40
                },
                new Constitution
                {
                    Id = 16,
                    Title = "Anayasa 16",
                    Content = "Bu, Anayasa 16'nın içeriğidir.",
                    CreatedByUserId = "user16",
                    CreatedAt = DateTime.UtcNow.AddDays(-60),
                    EndsAt = DateTime.UtcNow.AddDays(-55),
                    YesVotes = 80,
                    NoVotes = 20
                },
                new Constitution
                {
                    Id = 17,
                    Title = "Anayasa 17",
                    Content = "Bu, Anayasa 17'nin içeriğidir.",
                    CreatedByUserId = "user17",
                    CreatedAt = DateTime.UtcNow.AddDays(-65),
                    EndsAt = DateTime.UtcNow.AddDays(-60),
                    YesVotes = 70,
                    NoVotes = 30
                },
                new Constitution
                {
                    Id = 18,
                    Title = "Anayasa 18",
                    Content = "Bu, Anayasa 18'in içeriğidir.",
                    CreatedByUserId = "user18",
                    CreatedAt = DateTime.UtcNow.AddDays(-70),
                    EndsAt = DateTime.UtcNow.AddDays(-65),
                    YesVotes = 60,
                    NoVotes = 40
                },
                new Constitution
                {
                    Id = 19,
                    Title = "Anayasa 19",
                    Content = "Bu, Anayasa 19'un içeriğidir.",
                    CreatedByUserId = "user19",
                    CreatedAt = DateTime.UtcNow.AddDays(-75),
                    EndsAt = DateTime.UtcNow.AddDays(-70),
                    YesVotes = 50,
                    NoVotes = 50
                },
                new Constitution
                {
                    Id = 20,
                    Title = "Anayasa 20",
                    Content = "Bu, Anayasa 20'nin içeriğidir.",
                    CreatedByUserId = "user20",
                    CreatedAt = DateTime.UtcNow.AddDays(-80),
                    EndsAt = DateTime.UtcNow.AddDays(-75),
                    YesVotes = 100,
                    NoVotes = 0
                }
            );
        }
    }
}