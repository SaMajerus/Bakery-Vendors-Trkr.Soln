using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{ 

  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor() 
    {
      Vendor newVendor = new Vendor("test", "don't worry about it");  
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
   
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Don't worry about it";
      Vendor newVendor = new Vendor("test cafe", description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    { 
      //Arrange 
      string description = "Open-air corner cafe and coffee shop"; 
      Vendor newVendor = new Vendor("Annie's Coffee Bar & Cafe", description);

      //Act
      string updatedDescription = "Open-air coffee shop/cafe";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      // Arrange
      List<Vendor> newList = new List<Vendor> { };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string description01 = "Open-air coffee shop/cafe";
      string description02 = "Street shop that sells loaves of bread and pastries to breakfast makers";
      Vendor newVendor1 = new Vendor("Annie's Coffee Bar & Cafe", description01);
      Vendor newVendor2 = new Vendor("Simple Italian Breakfasts", description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "Coffee shop with a bakery mini-stand";
      Vendor newVendor = new Vendor("Delectables and Coffee!", description); 

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string description01 = "Open-air coffee shop/cafe";
      string description02 = "Street shop that sells loaves of bread and pastries to breakfast makers";
      Vendor newVendor1 = new Vendor("Annie's Coffee Bar & Cafe", description01);
      Vendor newVendor2 = new Vendor("Simple Italian Breakfasts", description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderAndReturnsUpdatedList_List<Order>()
    {
      //Arrange
      string description01 = "Open-air coffee shop/cafe";
      string description02 = "Street shop that sells loaves of bread and pastries to breakfast makers";
      Vendor newVendor1 = new Vendor("Annie's Coffee Bar & Cafe", description01);
      Vendor newVendor2 = new Vendor("Simple Italian Breakfasts", description02);
      Order orderToAdd = new Order("Pastries", "20 Pastries", 34, 10022022, 10042022);

      //Act

      newVendor1.AddOrder(orderToAdd);  
      List<Order> result = Vendor.Find(1).Orders; //Searches for -- and finds -- 'newVendor1' in Vendor list (using its Unique Id as a guide), and copies the object's List field to this variable.

      //Assert
      Assert.AreEqual(newVendor1.Orders, result); 
    }

/*
    [TestMethod]
    public void ShowOrders_FindsVendorAndReturnsCorrectOrdersList_List<Order>()
    {
      //Arrange
      string description01 = "Open-air coffee shop/cafe";
      string description02 = "Street shop that sells loaves of bread and pastries to breakfast makers";
      Vendor newVendor1 = new Vendor("Annie's Coffee Bar & Cafe", description01);
      Vendor newVendor2 = new Vendor("Simple Italian Breakfasts", description02);
      Order order1 = new Order("Planned Selection of food for day after tomorrow", "20 Bread Loaves, 30 Pastries", 120, 10022022, 10042022);
      Order order2 = new Order("Supply for next 3 Days", "60 Bread Loaves, 100 Pastries", 367, 10022022, 10032022); 


      //Act
      List<Order> result1 = newVendor1.ShowOrders(); 
      List<Order> result2 = newVendor2.ShowOrders();

      //Assert
      Assert.AreEqual(newVendor1.Orders, result1);
      Assert.AreEqual(newVendor2.Orders, result2);
    }
/*
    [TestMethod]
    public void Show_ReturnsCorrectOrderListFromVendor_OrderList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Vendor newVendor1 = new Vendor(description01);
      Vendor newVendor2 = new Vendor(description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }*/
  }
}