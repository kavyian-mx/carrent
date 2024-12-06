using Microsoft.AspNetCore.Mvc;

public class HomeController :Controller

{

    public IActionResult Index()
    {

        return View();
    }
     public IActionResult search(int year,string style,string make,string condition,string model,int price)
     {


        return View();
     }
}
