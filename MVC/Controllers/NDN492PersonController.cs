using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class NDN492Person : Controller
{
    private readonly NDN492Person ps = new NDN492Person();

    

    public IActionResult Index()

    {
       
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Malop,int Nhom, double SoTT)
    {
        ViewBag.Thongtin.NDN492Person = "NDN492"  ;
        return View();
    }

    
}
