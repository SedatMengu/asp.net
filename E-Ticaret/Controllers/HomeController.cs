using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.net2.Models;
using ETicaret.Models;
using System.Linq;

namespace asp.net2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ETicaretDBContext db = ETicaretDBContext();

    private static ETicaretDBContext ETicaretDBContext()
    {
        throw new NotImplementedException();
    }

    public object slide { get; private set; }

    [Route ("/")]
    public IActionResult Index()
    {
        var model = IndexViewModel();
        return View(model);
    }

    private string? IndexViewModel()
    {
        throw new NotImplementedException();
        

    }

    [Route ("/shop")]
    public IActionResult Shop()
    {
        return View();
    }

    [Route ("/blog")]
    public IActionResult Blog()
    {
        return View();
    }
    [Route ("/blogDetails")]
    public IActionResult BlogDetails()
    {
        return View();
    }
    [Route ("/checkOut")]
    public IActionResult CheckOut()
    {
        Band band = new Band();
        return View();
    }
    [Route ("/contact")]
    public IActionResult Contact()
    {
        return View();
    }
    [Route ("/faq")]
    public IActionResult FAQ()
    {
        return View();
    }
    [Route ("/login")]
    public IActionResult Login()
    {
        return View();
    }
    [Route ("/main")]
    public IActionResult Main()
    {
        return View();
    }
    [Route ("/product")]
    public IActionResult Product()
    {
        return View();
    }
    [Route ("/register")]
    public IActionResult Register()
    {
        return View();
    }
    [Route ("/shoppingCard")]
    public IActionResult ShoppingCard()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
