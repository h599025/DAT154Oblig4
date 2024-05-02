using BookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BookingSystem.Services;

namespace BookingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService customerService;
        private readonly IRoomService roomService;
        private readonly IBookingService bookingService;


        public HomeController(ILogger<HomeController> logger, ICustomerService customerService, IRoomService roomService, IBookingService bookingService)
        {
            _logger = logger;
            this.customerService = customerService;
            this.roomService = roomService;
            this.bookingService = bookingService;
            
        }

        public IActionResult LogOut()
        {
            if(HttpContext.Request.Cookies["user_email"] != null)
            {
                HttpContext.Response.Cookies.Delete("user_email");
            }
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer tempmodel)
        {
            // sjekk passord, email er legit

            Customer model = customerService.GetCustomerByEmail(tempmodel.Email);
            if (customerService.ValidatePassword(tempmodel.Password, model))
            {
                HttpContext.Response.Cookies.Append("user_email", model.Email);
                return RedirectToAction("BookingRequest");

            }

            ViewData["Message"] = "Email or password not correct/found";
            return View(tempmodel);
        }

        public IActionResult BookingRequest()
        {
            // Make sure the user is logged in
            if (HttpContext.Request.Cookies["user_email"] == null)
            {
                return RedirectToAction("Login");
            }

            return View();
        }

        public IActionResult ShowAvailableRooms(BookingRequest model)
        {

            // Make sure the user is logged in
            if (HttpContext.Request.Cookies["user_email"] == null)
            {
                return RedirectToAction("Login");
            }

            DateTime startDate = Convert.ToDateTime(model.CheckIn);

            DateTime endDate = Convert.ToDateTime(model.CheckOut);

            var rooms = new AvailableRooms
            {
                rooms = roomService.GetAvailableRoomsInDateRangeWithRightOrMoreNumberOfBeds(startDate, endDate, model.NumberOfBeds),
                CheckIn = startDate,
                CheckOut = endDate
            };
           
            return View(rooms);
        }

        public IActionResult UserBookings()
        {
            // Make sure the user is logged in
            if (HttpContext.Request.Cookies["user_email"] == null)
            {
                return RedirectToAction("Login");
            }

            Customer model = customerService.GetCustomerByEmail(HttpContext.Request.Cookies["user_email"]);

            return View(model);
        }

        [HttpPost]
        public IActionResult BookRoom(AvailableRooms model)
        {
            // Make sure the user is logged in
            if (HttpContext.Request.Cookies["user_email"] == null)
            {
                return RedirectToAction("Login");
            }

            Booking booking = new Booking
            {
                Roomnr = model.roomNr,
                Checkindate = model.CheckIn,
                Checkoutdate = model.CheckOut,
                Email = HttpContext.Request.Cookies["user_email"]!,
                Id = DateTime.Now.Millisecond
            };

            bookingService.AddBooking(booking);
            
            
            return RedirectToAction("UserBookings");
            
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer model)
        {
            if (customerService.ValidCustomer(model))
            {
                customerService.AddCustomer(model);
                return RedirectToAction("Login");
            }

            ViewData["Message"] = "One or more fields wrong, or email already taken.";
            return View();
    
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}