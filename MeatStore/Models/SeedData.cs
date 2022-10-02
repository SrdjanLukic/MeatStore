using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace MeatStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
                {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "T-BONE STEAK",
                        Description = "T-Bone is two prime steaks in one – a big meaty NY Strip and an impeccably tender filet, connected by a t-shaped bone.",
                        Category = "Beef",
                        Price = 35
                    },
                    new Product
                    {
                        Name = "FLANK STEAK",
                        Description = " Flank Steak is tender and flavorful with an extra dose of marbling. Perfect for tacos, salads and steak sandwiches. ",
                        Category = "Beef",
                        Price = 30
                    },
                    new Product
                    {
                        Name = "SIRLOINS",
                        Description = "Sirloin Steak is great for creating inspired — and affordable — family meals.",
                        Category = "Beef",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "FAROE ISLAND SALMON FILETS",
                        Description = "Meaty, full-flavored and nutrient-rich, our GMO-Free and Antibiotic-Free Faroe Islands Salmon is sustainably raised in free-flowing pens in the North Atlantic Ocean.",
                        Category = "Fish",
                        Price = 35
                    },
                    new Product
                    {
                        Name = "CRAB CAKES",
                        Description = "Our Maryland-style jumbo lump Crab Cakes are packed full of freshly caught premium blue crab meat and blended with the perfect amount of tangy mayo, zesty breadcrumbs, Dijon mustard and lemon. ",
                        Category = "Fish",
                        Price = 40
                    },
                    new Product
                    {
                        Name = "HARDWOOD SMOKED BACON",
                        Description = "Hardwood-smoked for a perfect mix of sweet and savory, our uncured, all-natural bacon is what breakfast dreams are made of. Cut from premium slabs of Heritage pork belly, our bacon is smoked the old-fashioned way, with no nitrates added.",
                        Category = "Pork",
                        Price = 14
                    },
                    new Product
                    {
                        Name = "GROUND PORK",
                        Description = "Ground Pork is great way to add a little twist to your traditional favorites – meatballs, chilis, burgers and stir-fries. Easy to cook and versatile to use, Ground Pork is a fantastic staple to have on hand for a mid-week meal.",
                        Category = "Pork",
                        Price = 8
                    },
                    new Product
                    {
                        Name = "PORK SAUSAGE WHEELS",
                        Description = "Hearty and classic, this pork sausage is perfect for your tailgate party and will make you look like an expert chef with minimal effort. Authentic flavor, the finest ingredients, and a hint of love in every bite. ",
                        Category = "Pork",
                        Price = 15
                    },
                    new Product
                    {
                        Name = "RACK OF LAMB",
                        Description = "Our grass-fed lamb comes in a frenched rack, humanely raised in lush Australian pastures, these free-range lambs are 100% grass-fed, yielding a perfect balance of flavor and tenderness.",
                        Category = "Lamb",
                        Price = 60
                    },
                    new Product
                    {
                        Name = "GROUND LAMB",
                        Description = "Ground from our 100% grass-fed Australian lamb, Ground Lamb is wildly flavorful alternative to some of your favorite ground meat dishes, like meatballs, stuffed peppers and lamb burgers and it’s the perfect flavor profile for Mediterranean dishes.",
                        Category = "Lamb",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "BONELESS LEG OF LAMB",
                        Description = "Our leg of lamb comes boneless, rolled and tied, so all you need to do is season it to your preference and place in the oven. It’s full-flavored, tender and easy to carve for the perfect holiday centerpiece.",
                        Category = "Lamb",
                        Price = 80
                    },
                    new Product
                    {
                        Name = "CHICKEN DRUMSTICKS",
                        Description = "Our Chicken Drumsticks come from chickens sustainably and humanely raised without hormones, antibiotics or steroids. Marinate, season and simply grill or bake in the oven.",
                        Category = "Poultry",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "BONELESS SKINLESS CHICKEN BREASTS",
                        Description = " Boneless Skinless Chicken Breasts come from chickens that are humanely raised. Simply defrost, and then grill for sandwiches, stir fry or sauté for your grandma’s Marsala. When you start with a quality, lean protein like this, the possibilities are endless.",
                        Category = "Poultry",
                        Price = 35
                    },
                    new Product
                    {
                        Name = "GROUND TURKEY",
                        Description = " Our turkey is ground from premium cuts of white breast meat. Breast meat is loaded in protein (7 grams/ounce) and low in fat (<1 gram/ounce), so you get a lot of flavor without it weighing you down.",
                        Category = "Poultry",
                        Price = 15
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
