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
/*
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