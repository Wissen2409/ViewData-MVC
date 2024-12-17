using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewData_MVC.Models;

namespace ViewData_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        //ViewData . ViewData Dictionary tipindedir.
        // temel olarak veri geçiçi olarak veri transfer etmek için kullanılan bir yapıdır!!

        // ViewData : Action ve View arasında veri transferi yapabileceğimiz bir yapıdır!!

        // Küçük ve geçici verileri taşımak için kullanılabilr
        
        // peki ya model ? ViewData model yazılmadığı zaman, actiondan view'a veri transfer etmek için kullanabiliriz!!

        // Tanımlayalım!!!

        //ViewData: key ve value değerleri taşır!!

        //ViewData["Key"]=value şeklinde çalışır, key içerisinde verdiğiniz değere view içerisinde ulaşabilirsiniz

        // ViewData modelden bağımsızdır!!
        //view data object tipinde çalışır, içerisinde atılan her veri boxing alırkende unboxing yapmak zorundayız!!

        ViewData["Message"]="Ben View data içerisnde taşındım!!";
        return View();
    }

    public IActionResult Privacy()
    {

        //ViewData, sadece bir actiondan view'a veri taşır, bir actiondan başka bir action'a veri taşıyamaz!!
        string message = ViewData["Message"].ToString();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
