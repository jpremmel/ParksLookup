using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Death Valley National Park", Location = "Eastern California; Nevada", SquareMileage = 5262, Terrain = "Harsh desert, salt-flats, sand dunes, badlands, valleys, canyons, mountains", Description = "The hottest, driest and lowest of all the national parks in the United States." },
                    new Park { ParkId = 2, Name = "Wrangell-St. Elias National Park & Preserve", Location = "Eastern region of South-central Alaska", SquareMileage = 20587, Terrain = "Mountains, glaciers, rivers, tundra, forest, tidewaters, alpine", Description = "The largest national park in the United States. This park includes a large portion of the Saint Elias Mountains, which include most of the highest peaks in the United States and Canada." },
                    new Park { ParkId = 3, Name = "Yellowstone National Park", Location = "Wyoming, Montana, Idaho", SquareMileage = 3471, Terrain = "Mountains, canyons, rivers, waterfalls, forests", Description = "Established in 1872, it was the first national park in the United States. The volcanic plumbing beneath the park is still active, giving energy to more than ten thousand hot springs, mud pots, terraces, and geysers." }
                );
        }
    }
}