using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using viewModels_fun.Models;


namespace viewModels_fun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Here is a Message!";
            Message msg = new Message()
            {
                content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
            return View("Index", msg);
        }
        [Route("numbers")]
        public IActionResult Numbers()
        {
            ViewData["Title"] = "Here are some numbers!";
            Numbers num = new Numbers()
            {
                numList = new List<int> {1,2,3,10,43,5}
            };
            return View("Numbers", num);

        }
        [Route("names")]
        public IActionResult Names()
        {
            ViewData["Title"] = "Here are some Users!";
            Names names = new Names()
            {
                nameList = new List<string> {"Ryan Giffin", "John Jacob", "The Rock", "Jennifer Aniston", "Ryan Reynolds"}
            };
            return View("Names", names);
        }
        [Route("user")]
        public IActionResult singleUser()
        {
            ViewData["Title"] = "Here is a User!";
            User user = new User()
            {
                user = "Ryan Giffin"
            };
            return View("singleUser", user);
        }
    }
}