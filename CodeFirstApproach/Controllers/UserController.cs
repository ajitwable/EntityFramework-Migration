using CodeFirstApproach.Context;
using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstApproach.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var user = _context.User.ToList();
            return View(user);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
