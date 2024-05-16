using BloodBankPR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BloodBankPR.Controllers
{
    public class UserController : Controller
    {
        public readonly libraryDBContext _context;

        public UserController(libraryDBContext context)
        {
            _context = context;
        }
        public IActionResult MainContent()
        {

            //int oNeg,oPlus,bNeg,bPlus,abNeg,abPlus,aPlus,aNeg;

            ViewBag.oNeg = _context.Book.Where(x => x.BookId == 1).First().Qnt;
            ViewBag.oPlus = _context.Book.Where(x => x.BookId == 2).First().Qnt;
            ViewBag.bNeg = _context.Book.Where(x => x.BookId == 3).First().Qnt;
            ViewBag.bPlus = _context.Book.Where(x => x.BookId == 4).First().Qnt;
            ViewBag.abNeg = _context.Book.Where(x => x.BookId == 5).First().Qnt;
            ViewBag.abPlus = _context.Book.Where(x => x.BookId == 6).First().Qnt;
            ViewBag.aPlus = _context.Book.Where(x => x.BookId == 7).First().Qnt;
            ViewBag.aNeg = _context.Book.Where(x => x.BookId == 8).First().Qnt;

            return View();
        }
            
   
       
        public IActionResult WhoWeAre()
        {   if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult DonationRequestMain()
        {
           
            
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
           return RedirectToAction("Index", "Home");
        }
       
       
        [HttpPost]
      
        [HttpPost]
        public IActionResult Profile()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                var user = _context.User.Where(x => x.UserId == HttpContext.Session.GetInt32("UserId")).SingleOrDefault();
            if (user != null)
            {
                ViewData["Datum"] = user.BirthDate.ToShortDateString();
                return View(user);
            }
            return NotFound();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult UpdateProfile(int id
            , string address, string phone)
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                //update
                var user = _context.User.Where(x => x.UserId == id).SingleOrDefault();
            if (user != null)
            {
                user.Address = address;
               
                _context.Update(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Doctors");
            }
            return RedirectToAction("Index", "Home");
        }


       

        
       

        public IActionResult InsertDonationRequest()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                return View(_context.Book.ToList());
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult InsertDonationRequest(string title,string desc,int qtn,
            int bloodtypeID,DateTime dateTimeSart , DateTime dateTimeEnd)
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                DonationRequest donationRequest = new DonationRequest();                 
            donationRequest.BookName = desc; 
                     
            donationRequest.UserId =(int) HttpContext.Session.GetInt32("UserId");
            _context.Add(donationRequest);
            _context.SaveChanges();
            return RedirectToAction("DonationRequest");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Donate(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                var don = _context.DonationRequest.
                Where(d=>d.DonatRequestionId == id).FirstOrDefault();
            if (don != null)
            {
                return View(don);
            }
            return RedirectToAction("DonationRequestMain");
            }
            return RedirectToAction("Index", "Home");
        }
      
      

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "User")
            {
                HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("Role");
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
