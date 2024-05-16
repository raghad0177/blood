using BloodBankPR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Http;
using Aspose.Email;
using Aspose.Email.Clients;
using Aspose.Email.Clients.Smtp;

namespace BloodBankPR.Controllers
{
    public class HomeController : Controller
    {
        public readonly libraryDBContext _context;

        static List<string> signInError = new List<string>();
        static List<string> ResetError = new List<string>();
        static List<string> RegisterError = new List<string>();
        static List<string> otpError = new List<string>();
        public HomeController(libraryDBContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
           
            //int oNeg,oPlus,bNeg,bPlus,abNeg,abPlus,aPlus,aNeg;

            ViewBag.oNeg   = _context.Book.Where(x => x.BookId == 1).First().Qnt;
            ViewBag.oPlus  = _context.Book.Where(x => x.BookId == 2).First().Qnt;
            ViewBag.bNeg   = _context.Book.Where(x => x.BookId == 3).First().Qnt;
            ViewBag.bPlus  = _context.Book.Where(x => x.BookId == 4).First().Qnt;
            ViewBag.abNeg  = _context.Book.Where(x => x.BookId == 5).First().Qnt;
            ViewBag.abPlus = _context.Book.Where(x => x.BookId == 6).First().Qnt;
            ViewBag.aPlus  = _context.Book.Where(x => x.BookId == 7).First().Qnt;
            ViewBag.aNeg   = _context.Book.Where(x => x.BookId == 8).First().Qnt;

            return View();
        }

        public IActionResult WhoWeAre()
        {
            return View();
        }
        public IActionResult AvailableUnit()
        {

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
        public IActionResult DonationRequest()
        {
            //All Donation Request
           

            return View();
            //Determine how is Request to recive donation via our portal 


           
        }

        public IActionResult SignIn()
        {
            signInError.Clear();
            return View(signInError);
        }
        [HttpPost]
        public IActionResult SignIn(string email, string password)
        {
            string orgMail=email.Trim();
            email = GetSecureString(email);
            password = GetSecureString(password);
            var auth = _context.Login.Where(x => x.Username.Equals(email)
            && x.Password.Equals(password)).SingleOrDefault();
            if(auth != null)
            {
                HttpContext.Session.SetInt32("UserId", (int)auth.UserId);
                var user = _context.User.Where(u=>u.UserId.Equals(auth.UserId)).FirstOrDefault();
                if(user != null)
                {
                    HttpContext.Session.SetString("Mail", email);
                    switch (user.UserTypeId)
                    {

                        case 1:
                            HttpContext.Session.SetString("Role", "Admin");
                           
                            break;
                            case 2:
                            HttpContext.Session.SetString("Role", "Doctor");
                            
                            break;
                            case 3:
                            HttpContext.Session.SetString("Role", "User");
                           
                            break;
                    }
                    Random random = new Random();
                    int code = random.Next(111111, 999999);
                    Verification verification = new Verification();
                    verification.UserEmail = orgMail;
                    verification.Code = code.ToString();
                    verification.ExpireDate = DateTime.Now.AddMinutes(10);
                    _context.Add(verification);
                    _context.SaveChanges();

                    SendOtpViaEmail(verification.Code, verification.UserEmail);

                    return RedirectToAction("ConfitmOTPSignIn");

                }
                signInError.Add("You Dont have any Access to this site");
            }
            signInError.Add("Wrong User Name Or Password");

            return View(signInError);
        }
           
        public IActionResult Register()
        {
            var bloodType = _context.Book.ToList();
            ResetError.Clear();
            ViewBag.errors = RegisterError;
            return View(bloodType);
        }
        [HttpPost]
        public async Task<IActionResult> Register(string fname, string lname, string email , string password,
            int bloodTypeId,DateTime birthDate,string address , string phone)
        {
            if (!IsValidEmail(email))
            {
                RegisterError.Add("User Correct Format for email");
            }
            if (!IsValidPassword(password))
            {
                RegisterError.Add("Incorrect Password Format - Please Enter \n" +
                    "at least 3 character one uppercase one lowercase  and 2 number and 1 symbol");
            }
           
            if (!IsValidBirthDate(birthDate))
            {
                RegisterError.Add("Invalid Age");
            }
            if (IsEmailExisit(email))
            {
                RegisterError.Add("This Email Already Taken");
            }


            ViewBag.errors = RegisterError;
            if(RegisterError.Count > 0 )
                return View(_context.Book.ToList()); 
            User newBloodBankUser = new User();
            newBloodBankUser.Name = fname + "  " + lname;
            newBloodBankUser.Email = email;
            newBloodBankUser.Address = address;
            
            newBloodBankUser.BirthDate = birthDate;
          

            newBloodBankUser.UserTypeId = 3;
            await _context.AddAsync(newBloodBankUser);
            await _context.SaveChangesAsync();
            Login login = new Login();
            login.Username = GetSecureString(email) ;
            login.Password = GetSecureString(password); ;
            login.UserId = _context.User.OrderByDescending(x=>x.UserId).FirstOrDefault().UserId;
            await _context.AddAsync(login);
            await _context.SaveChangesAsync();

            return RedirectToAction("SignIn");
        }

        public IActionResult ResetPassword()
        {
            ResetError.Clear();
            ViewBag.errors = ResetError;
            return View();
        }
        [HttpPost]
        public IActionResult ResetPassword(string email)
        {
            if (IsEmailExisit(email))
            {
                //sent otp 
                Random random = new Random();
                int code = random.Next(111111, 999999);
                Verification verification = new Verification();
                verification.UserEmail = email;
                verification.Code = code.ToString();
                verification.ExpireDate = DateTime.Now.AddMinutes(10);
                _context.Add(verification);
                _context.SaveChanges();

                SendOtpViaEmail(verification.Code, verification.UserEmail);

            }
            else
            {
                ResetError.Add("This Email Dose not  Taken");
            }

            ViewBag.errors = ResetError;
            return RedirectToAction("ConfitmOTP");
        }

        public IActionResult ConfitmOTP()
        {
            otpError.Clear();
            ViewBag.errors = otpError;
            return View();
        }
        [HttpPost]
        public IActionResult ConfitmOTP(string otp,string newPass,string confirmPassword)
        {
            if (newPass.Equals(confirmPassword))
            {
                var verific=_context.Verification.Where(x=>x.Code==otp).FirstOrDefault();
                if(verific != null)
                {
                    string email = GetSecureString(verific.UserEmail);
                    var login = _context.Login.Where(x=>x.Username == email).FirstOrDefault();
                    if(login != null)
                    {
                        login.Password = GetSecureString(newPass);
                        _context.Update(login);
                        _context.SaveChanges();
                    }
                }
            }
            else
            {
                otpError.Add("Password dose not matched");
            }
            ViewBag.errors = otpError;
            return RedirectToAction("SignIn");
        }

        public IActionResult ConfitmOTPSignIn()
        {
            otpError.Clear();
            ViewBag.errors = otpError;
            return View();
        }
        [HttpPost]
        public IActionResult ConfitmOTPSignIn(string otp)
        {
           
                var verific = _context.Verification.Where(x => x.Code == otp && x.ExpireDate > DateTime.Now).FirstOrDefault();
                if (verific != null)
                {
                    string email = HttpContext.Session.GetString("Mail");
                    var login = _context.Login.Where(x => x.Username == email).FirstOrDefault();
                    if (login != null)
                    {
                    string role= HttpContext.Session.GetString("Role");
                    if(role == "Admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if(role == "User")
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Doctor");
                       

                    }
      
                }
                }
                else
                {
                    otpError.Add("Password dose not matched");
                }
           
           
            ViewBag.errors = otpError;
            return RedirectToAction("SignIn");
        }

        public string GetSecureString(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                //salt round
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

        static bool IsValidEmail(string email) {

            char[] chars = email.ToCharArray();

            int atSign = 0;

            foreach (char c in chars)
            {
                if(c == 64)
                {
                    atSign++;
                    break;
                }
                
            }
            bool isHasDomain = email.Contains(".com") || email.Contains(".org") || email.Contains(".net");
            if (atSign >=1 && isHasDomain)
            {
                return true;    
            }

            return false;
        }

        static bool IsValidPassword(string password)
        {
            char[] chars = password.ToCharArray();
            int digitCount = 0, characterCount = 0, latterCount = 0;
            foreach (char c in chars)
            {
                if ((c >= 33 && c <= 47)||(c>=58 && c<=64) || (c>=91 && c<=96) || (c>=123 && c<=126))
                {
                    ++characterCount;
                }else if(c>=47 && c <= 57)
                {
                    ++digitCount;
                }
                else
                {
                    ++latterCount;
                }
            }

            if(latterCount >= 3 && digitCount >=2 && characterCount >= 1)
            {
                return true;
            }
            return false;
        }

        


        static bool IsValidBirthDate(DateTime date) { 

            if(DateTime.Now.AddYears(-18) >= date)
            {
                return true;
            }

            return false;
        }

        bool IsEmailExisit(string currentEmail)
        {
            var user = _context.User.Where(x=>x.Email == currentEmail).SingleOrDefault();

            if(user != null)
                return true;

            return false;
        }

        void SendOtpViaEmail(string code , string email)
        {
            // Create a new instance of MailMessage class
            MailMessage message = new MailMessage();

            // Set subject of the message, body and sender information
            message.Subject = "Blood Bank Verficiation Code";
            message.Body = "Use this Following Code  \n "+code+"\nto Confirm Your Opertaion Kindly Remindrer it's valid for 10 minutes since now";
            message.From = new MailAddress("abdullahraghad121@outlook.com", "Blood Bank", false);
            // Add To recipients and CC recipients
            message.To.Add(new MailAddress(email, "", false));

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
