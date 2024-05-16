using Aspose.Email.Clients;
using BloodBankPR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Linq;
using Aspose.Email;
using Aspose.Email.Clients.Smtp;

namespace BloodBankPR.Controllers
{
    public class DoctorController : Controller
    {
        public readonly libraryDBContext _context;
        public DoctorController(libraryDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //dashboard and stastics in website

            return RedirectToAction("Index", "Home");
        }
        public IActionResult DonationRequest()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Doctor")
            {
                //All Donation Request
                var donationRequest = _context.DonationRequest
                .Where(x => x.IsApproved == null || x.IsApproved == true).ToList();
                var bookid = _context.Book.ToList();
                var users = _context.User.ToList();


                //Determine how is Request to recive donation via our portal 

              

                ViewBag.bloodType = _context.Book.ToList();
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Donatoions(int id)
        {

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Profile()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Doctor")
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
            //update
            var user = _context.User.Where(x => x.UserId == id).SingleOrDefault();
            if (user != null)
            {
                user.Address = address;

                _context.Update(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    





       
       
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("UserId") != null && HttpContext.Session.GetString("Role") == "Doctor")
            {
                HttpContext.Session.Remove("UserId");
                HttpContext.Session.Remove("Role");
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
      

      
        void SendOtpViaEmail(string mess, string email,string subject)
        {
            // Create a new instance of MailMessage class
            MailMessage message = new MailMessage();

            // Set subject of the message, body and sender information
            message.Subject = subject;
            message.Body = mess;
            message.From = new MailAddress("abdullahraghad121@outlook.com", "BloodBank", false);
            // Add To recipients and CC recipients
            message.To.Add(new MailAddress(email, "Recipient 1", false));

            // Create an instance of SmtpClient class
            SmtpClient client = new SmtpClient();

            // Specify your mailing Host, Username, Password, Port # and Security option
            client.Host = "smtp.office365.com";
            client.Username = "abdullahraghad121@outlook.com";
            client.Password = "Roro2001**";
            client.Port = 587;
            client.SecurityOptions = SecurityOptions.SSLExplicit;
            try
            {
                // Send this email
                client.Send(message);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }


        }
    }
}
