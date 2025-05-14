using System.Diagnostics;
using Ardonagh_Task_Application.Models;
using Ardonagh_Task_Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ardonagh_Task_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ICustomerService customerService, ILogger<HomeController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetCustomers();
            return View(customers);
        }

        public RedirectResult Insert(CustomerRecord customer)
        {
            _customerService.AddCustomer(customer);
            return Redirect("https://localhost:7232/");            
        }

        [HttpGet]
        public JsonResult PopulateForm(int id)
        {
            var customer = _customerService.GetCustomer(id);
            return Json(customer);
        }

        public RedirectResult Update(CustomerRecord customer)
        {
            _customerService.UpdateCustomer(customer);
            return Redirect("https://localhost:7232/");
        }
    }
}
