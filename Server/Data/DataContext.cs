namespace EcommerceBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "The Hitchhiker's Guide to the Galaxy",
                     Description = "The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8] ",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                     Price = 7.59m
                 },
                new Product
                {
                    Id = 2,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "One Thursday morning, Arthur Dent discovers that his house is to be immediately demolished to make way for a bypass. He tries delaying the bulldozers by lying down in front of them. Ford Prefect, a friend of Arthur's, convinces him to go to a pub with him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7a/Hitchhikers_guide_to_the_galaxy.jpg",
                    Price = 5m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8] ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 50.42m
                },
                new Product
                {
                    Id = 4,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "One Thursday morning, Arthur Dent discovers that his house is to be immediately demolished to make way for a bypass. He tries delaying the bulldozers by lying down in front of them. Ford Prefect, a friend of Arthur's, convinces him to go to a pub with him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7a/Hitchhikers_guide_to_the_galaxy.jpg",
                    Price = 45.90m
                }
        );

        }
        public DbSet<Product> Products { get; set; }
    }
}
