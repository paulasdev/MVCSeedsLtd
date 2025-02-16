using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCSeedsLtd.Models;

namespace MVCSeedsLtd.Controllers;

public class SeedsController : Controller
{
    private readonly ILogger<SeedsController> _logger;

    public SeedsController(ILogger<SeedsController> logger)
    {
        _logger = logger;
    }

    public IActionResult FlowerSeeds()
    {
        return View();
    }
     public IActionResult VegetableSeeds()
    {
        return View();
    }
}