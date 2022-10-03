using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("vendors/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders); 
    }

    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor ven = Vendor.Find(artistId);
      return View(ven);  //Route: 'Bakery/Views/Orders/New.cshtml' 
    }

    [HttpPost("/orders/new")]   //Only for a new Vendor. 
    public ActionResult Create(string orderTitle, string orderDescription, int price, int dateSubbed, int deliverByDate)
    {
      Order newOrder = new Order(orderTitle, orderDescription, price, dateSubbed, deliverByDate);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    //This one creates new Orders for a given Vendor, NOT for new Vendors:  
    //[HttpPost("orders/{vendorId}/orders/new")]  
    [HttpPost("/vendors/{vendorId}/orders")] 
    public ActionResult Create(int vendorId, string orderName, string orderDescription, int price, int dateSubmitted, int dateDeliver)  
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, orderDescription, price, dateSubmitted, dateDeliver);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}
