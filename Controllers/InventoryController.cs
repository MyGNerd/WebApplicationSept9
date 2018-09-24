using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationSept9.Models;

namespace WebApplicationSept9.Controllers
{
    public class InventoryController : Controller
    {
        public ActionResult WebgridSample()
        {
            ObservableCollection<Product> inventoryList = new ObservableCollection<Product>();
            inventoryList.Add(new Product { Id = "P101", Name = "Computer", Description = "All type of computers", Quantity = 800 });
            inventoryList.Add(new Product { Id = "P102", Name = "Laptop", Description = "All models of Laptops", Quantity = 500 });
            inventoryList.Add(new Product { Id = "P103", Name = "Camera", Description = "Hd  cameras", Quantity = 300 });
            inventoryList.Add(new Product { Id = "P104", Name = "Mobile", Description = "All Smartphones", Quantity = 450 });
            inventoryList.Add(new Product { Id = "P105", Name = "Notepad", Description = "All branded of notepads", Quantity = 670 });
            inventoryList.Add(new Product { Id = "P106", Name = "Harddisk", Description = "All type of Harddisk", Quantity = 1200 });
            inventoryList.Add(new Product { Id = "P107", Name = "PenDrive", Description = "All type of Pendrive", Quantity = 370 });
            return View(inventoryList);
        }
        // GET: Inventory
        public ActionResult Index()
        {
            //ObservableCollection<Product> inventoryList = new ObservableCollection<Product>();
            //inventoryList.Add(new Product { Id = "P101", Name = "Computer", Description = "All type of computers", Quantity = 800 });
            //inventoryList.Add(new Product { Id = "P102", Name = "Laptop", Description = "All models of Laptops", Quantity = 500 });
            //inventoryList.Add(new Product { Id = "P103", Name = "Camera", Description = "Hd  cameras", Quantity = 300 });
            //inventoryList.Add(new Product { Id = "P104", Name = "Mobile", Description = "All Smartphones", Quantity = 450 });
            //inventoryList.Add(new Product { Id = "P105", Name = "Notepad", Description = "All branded of notepads", Quantity = 670 });
            //inventoryList.Add(new Product { Id = "P106", Name = "Harddisk", Description = "All type of Harddisk", Quantity = 1200 });
            //inventoryList.Add(new Product { Id = "P107", Name = "PenDrive", Description = "All type of Pendrive", Quantity = 370 });
            //return View(inventoryList);
            return View();
        }
        [HttpPost]
        public PartialViewResult DisplayEmployees(string id)
        {
            try
            {
                //ObservableCollection<Product> inventoryList = new ObservableCollection<Product>();
                List<Product> inventoryList = new List<Product>();
                int empid = Convert.ToInt32(id);
                if (empid == 1)
                {
                    inventoryList.Add(new Product { Id = "P103", Name = "Camera", Description = "Hd  cameras", Quantity = 300 });
                    inventoryList.Add(new Product { Id = "P107", Name = "PenDrive", Description = "All type of Pendrive", Quantity = 370 });
                    inventoryList.Add(new Product { Id = "P108", Name = "PenDrive", Description = "All type of Monitor", Quantity = 470 });
                }
                if (empid == 2)
                {
                    inventoryList.Add(new Product { Id = "P102", Name = "Laptop", Description = "All models of Laptops", Quantity = 500 });
                    inventoryList.Add(new Product { Id = "P105", Name = "Notepad", Description = "All branded of notepads", Quantity = 670 });
                }
                if (empid == 3)
                {
                    inventoryList.Add(new Product { Id = "P101", Name = "Computer", Description = "All type of computers", Quantity = 800 });
                    inventoryList.Add(new Product { Id = "P106", Name = "Harddisk", Description = "All type of Harddisk", Quantity = 1200 });
                }
                //According to the id to query the database
                //var query = from ee in context.Employees
                //            where ee.EmployeeID == empid
                //            select ee;

                return PartialView("DisplayEmployeeWebGridView", inventoryList.ToList());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}