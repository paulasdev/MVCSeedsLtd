using Microsoft.AspNetCore.Mvc;
using MVCSeedsLtd.Models;
using System.Collections.Generic;

namespace MVCSeedsLtd.Controllers
{
    public class TestModelController : Controller
    {
        public IActionResult Index()
        {
            MVCSeedsLtd.Models.Seeds myTestSeedPacket = new Models.Seeds
            {
                Id = 1,
                Category = "Flowers",
                SeedName = "Flowers",
                Variaty = "Purple Glory",
                Properties = "FlowersEarly",
                Description = "Attract Bees",
                No_In_Stock = 100
            };
            return View(myTestSeedPacket);
        }

        public IActionResult DisplayList()
        {
            // Create a list of seeds objects
            List<MVCSeedsLtd.Models.Seeds> seedList = new List<Models.Seeds>
            {
                new Models.Seeds
                {
                    Id = 2,
                    Category = "Flowers",
                    SeedName = "Flowers",
                    Variaty = "Purple Glory",
                    Properties = "FlowersEarly",
                    Description = "Attract Bees",
                    No_In_Stock = 100
                },
                new Models.Seeds
                {
                    Id = 3, // Ensure all items have an Id
                    Category = "Vegetable",
                    SeedName = "Potato",
                    Variaty = "Cara",
                    Properties = "Main Crop",
                    Description = "Good flavour",
                    No_In_Stock = 10
                }
            };

            // Pass the seed list to the view
            return View(seedList);
        }
    }
}