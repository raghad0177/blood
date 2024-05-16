using BloodBankPR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;


namespace BloodBankPR.Controllers
{
    public class AdminController : Controller
    {
        public readonly libraryDBContext _context;
        public AdminController(libraryDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                //dashboard and stastics in website
            ViewBag.siteUser     = _context.User.Count();
            ViewBag.units = _context.Book.Sum(x => x.Qnt);
            ViewBag.donation     = _context.DonationRequest.Count();
           

           
            return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult DonationRequest()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                //All Donation Request
            var donationRequest =_context.DonationRequest.ToList();
            var BookId = _context.Book.ToList();    
            var users = _context.User.ToList();
           

            //Determine how is Request to recive donation via our portal 

           

            ViewBag.BookId = _context.Book.ToList();
           
            }
            return RedirectToAction("Index", "Home");
        }

      
      

       
        public IActionResult AvailableUnits()
        {

            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                //AvailableUnits 
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
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Doctors()
        {

            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                //Doctors 
                return View(_context.User.Where(x=>x.UserTypeId==2).ToList());
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult InsertDoctors()
        {
            //Doctors 
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult InsertDoctor(string fname,string lname,string email
            ,string address,string phone,DateTime birthDate,string password)
        {
           
            //Insert 
            User newBloodBankDoctor = new User();
            newBloodBankDoctor.Name = fname + "  " + lname;
            newBloodBankDoctor.Email = email;
            newBloodBankDoctor.Address = address;
         
            newBloodBankDoctor.BirthDate = birthDate;
            //newBloodBankDoctor.BloodTypeId = bloodTypeId;

            newBloodBankDoctor.UserTypeId = 2;
            _context.Add(newBloodBankDoctor);
            _context.SaveChanges();
            Login login = new Login();
            login.Username = GetSecureString(email);
            login.Password = GetSecureString(phone);
            login.UserId = _context.User.OrderByDescending(x => x.UserId).FirstOrDefault().UserId;
            _context.Add(login);
            _context.SaveChanges();
            return RedirectToAction("Doctors");
        }

       
        public IActionResult UpdateDoctor(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                //update
                var user = _context.User.Where(x => x.UserId == id).SingleOrDefault();
            
            return RedirectToAction("Doctors");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult UpdateDoctor(int id
            , string address, string phone, string password)
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

        public IActionResult RemoveDoctor(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
             var logim = _context.Login.Where(y => y.UserId == id).SingleOrDefault();
             var user = _context.User.Where(x => x.UserId == id).SingleOrDefault();
            if (user != null && logim!=null)
            {
                    _context.Remove(logim);
                    _context.SaveChanges();
                    _context.Remove(user);
               _context.SaveChanges();
             }
            return RedirectToAction("Doctors");
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
      
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Admin")
            {
                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("Role");
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        public string GetSecureString(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                input = GetMd5Hash(md5Hash, GetMd5Hash(md5Hash, GetMd5Hash(md5Hash, GetMd5Hash(md5Hash, input))));
            }

            return EnryptString(input);
        }




        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        static string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decrypted = "";
                throw fe;
            }
            return decrypted;
        }

        static string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
    }
}
