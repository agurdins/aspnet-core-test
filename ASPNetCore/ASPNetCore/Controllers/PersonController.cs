using ASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "Deivids";
            person.Surname = "Agriņš";
            person.Age = 22;
            person.Email = "deivids.agrins@gmail.com";
            person.IsMale = true;
            person.Adress = "Šarlotes tante";

            return View(person);
        }
    }
}
