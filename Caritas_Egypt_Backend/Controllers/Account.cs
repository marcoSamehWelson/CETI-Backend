using Caritas_Egypt_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Caritas_Egypt_Backend.Controllers
{
    public class Account : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public Account(CETICaretasEgyptContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user) {
            HttpContext.Session.Remove("UserType");
           
            if (ModelState.IsValid)
            {
                User usersession = new User();    
                //branch.Id = Guid.NewGuid();
                //_context.Add(branch);
                //await _context.SaveChangesAsync();
                if (UserExists(user.Email, user.TempPassword))
                {
                    // _context.User
                    usersession = _context.User.Where(e => e.Email == user.Email && e.TempPassword == user.TempPassword).FirstOrDefault();
                    HttpContext.Session.SetInt32("UserType",(int) usersession.UserTypeId); 
                    return RedirectToAction(nameof(Index), "Home");


                }
                return View(user);
            }
            return View(user);

           
           
                 
        
        
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = Guid.NewGuid();
                user.UserTypeId = Enums.UserType.Trainer;
                user.IsActive = true;
                user.IsVerified = true;
                user.LastPasswordChage = DateTime.Now;
                user.LastPasswordChangeBy = Guid.NewGuid();

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        private bool UserExists(string email,string password)
        {
            return _context.User.Any(e => e.Email == email && e.TempPassword==password);
        }
    }
}
