using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Agendamento.Models;
using Sistema_de_Agendamento.Data;

namespace Sistema_de_Agendamento.Controllers
{
    public class UserController : Controller
    {
        private readonly ProgramDbContext _context;
        public UserController(ProgramDbContext context) {
            _context = context;
        }

        // GET: User
        public IActionResult Client()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Client([Bind("Username,Email,Senha,TermsAndCondition")] User_register user) {
            if (ModelState.IsValid) {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Index


    }
}