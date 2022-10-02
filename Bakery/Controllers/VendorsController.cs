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
      return View();
    }

/*
    //This is an experiment -- don't know if it'll work. (When clicked, it's supposed to display(/Show(?)) all of a given Vendor's listed Orders).
    [HttpGet("/vendors/show")]
    public ActionResult Show()
    {
      List<Order> allOrdersFromVendor = Vendor.Orders.GetAll();  //'Orders' is the name of the List<Order> field for any given Vendor object.
      return View(allOrdersFromVendor);
    }*/

/*
    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<Item> categoryItems = selectedCategory.Items;
      model.Add("category", selectedCategory);
      model.Add("items", categoryItems);
      return View(model);
    }

    //This one creates new Items within a given Category, not new Categories:  
    [HttpPost("/categories/{categoryId}/items")]  
    public ActionResult Create(int categoryId, string itemDescription)  
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }*/
  }
}
