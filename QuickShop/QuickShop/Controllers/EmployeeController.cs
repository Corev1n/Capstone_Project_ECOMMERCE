using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickShop.Models;

namespace QuickShop.Controllers
{
    public class EmployeeController : Controller
    {
        private ECommerceManagementDbContext employeeManagmentDbContext;
        public EmployeeController(ECommerceManagementDbContext employeeManagmentDbContext) {
            this.employeeManagmentDbContext = employeeManagmentDbContext;
        }
        
        public IActionResult Index()
        {
            string[] breadcrumbs = { "Main", "Dashboard"};
            ViewData["breadcrumbs"] = breadcrumbs;
            return View();
        }
        public IActionResult New()
        {
            string[] breadcrumbs = { "Main", "User", "New User"};
            ViewData["breadcrumbs"] = breadcrumbs;
            return View();
        }
        public IActionResult Users()
        {
            string[] breadcrumbs = { "Main", "User", "Users" };
            ViewData["breadcrumbs"] = breadcrumbs;
            return View(employeeManagmentDbContext.Employees);
        }
        public IActionResult Activities()
        {
            string[] breadcrumbs = { "Main", "User", "Activities" };
            ViewData["breadcrumbs"] = breadcrumbs;
            return View();
        }
        public IActionResult Archives()
        {
            string[] breadcrumbs = { "Main", "User", "Archives" };
            ViewData["breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
