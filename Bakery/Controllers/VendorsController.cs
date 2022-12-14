using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View(); //Displays this file on the user's screen:  'Bakery/Views/Vendors/New.cshtml' 
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string desc)
    {
      Vendor newVendor = new Vendor(vendorName, desc);
      return RedirectToAction("Index");  //Goes to method on Line 12. 
    }

    [HttpGet("/vendors/{id}")] //If User clicks on a Vendor with Unique-Id 'id' while at ''/vendors'', then we do this. 
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);  //Shows the user Orders from their selected Vendor; routes to  'Bakery/Views/Vendors/Show.cshtml' (?). 
    }

    //This one creates new Orders within a given Vendor, not a new Vendor:  
    [HttpPost("/vendors/{vendorId}/orders/new/")] 
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int price, int d8Entered, int deliverBy)  
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, price, d8Entered, deliverBy);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);  //Routes to 'Bakery/Views/Vendors/Show.cshtml' 
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

  }
}