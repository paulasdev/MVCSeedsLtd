using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCSeedsLtd.Models;

namespace MVCSeedsLtd.Controllers;

public class PotatoController : Controller
{
    private readonly ILogger<PotatoController> _logger;

    public PotatoController(ILogger<PotatoController> logger)
    {
        _logger = logger;
    }

    public IActionResult BlightResistant()
    {
        return View();
    }
     public IActionResult MainCrop()
    {
        return View();
    }
}