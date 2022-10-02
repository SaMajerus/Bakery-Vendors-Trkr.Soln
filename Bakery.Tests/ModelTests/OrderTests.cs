using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{

  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose(){
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrderObject_Order()
    {
      Order newOrder = new Order("test", "this is a test", 0, 09302022, 10022022);  
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "30 Bread Loaves, 20 Pastries";
      Order newOrder = new Order("test", description, 134, 10012022, 10032022);  //Params: (string name, string description, int totalPrice, int d8) 
        //[Using last week's CR program to calculate the price]

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "30 Bread Loaves, 20 Pastries";
      Order newOrder = new Order("test", description, 134, 10032022);  //[Using last week's CR program to calculate the prices]

      //Act
      string updatedDescription = "30 Bread Loaves, 30 Pastries";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "10 Bread Loaves, 10 Pastries";
      string description02 = "50 Bread Loaves, 50 Pastries";
      Order newOrder1 = new Order("Test-order 1", description01, 52, 10032022);
      Order newOrder2 = new Order("Test-order 2", description02, 254, 10032022); 
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "15 Bread Loaves, 1 Pastry";
      Order newOrder = new Order("test", description, 52, 10012022, 10032022);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string description01 = "100 Bread Loaves, 50 Pastries";
      string description02 = "5 Bread Loaves, 5 Pastries";
      Order newOrder1 = new Order("Order 1", description01, 419, 10012022, 10032022);
      Order newOrder2 = new Order("Order 2", description02, 29, 10012022, 10032022);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}






    /*
    [TestMethod]
    public void DealApplies_CheckCompatabilityWithBreadDeal_False()
    {
      Bread test = new Bread(2);
      Assert.AreEqual(false, test.DealApplies());
    }

    [TestMethod]
    public void DealApplies_UseBranchingToCheckBreadDealCompatability_True()
    {
      Bread test1 = new Bread(1);
      Bread test2 = new Bread(2);
      Bread test3 = new Bread(3);
      Assert.AreEqual(false, test1.DealApplies());
      Assert.AreEqual(false, test2.DealApplies());
      Assert.AreEqual(true, test3.DealApplies());
    }

    [TestMethod]
    public void DetermineTotalPrice_UseBranchingToMakeCalculationsBasedOnQuantity_Int()
    { 
      Bread test1 = new Bread(1); 
      Bread test2 = new Bread(2); 
      Bread test3 = new Bread(3); 
      Bread test4 = new Bread(4);
      Bread test5 = new Bread(8); 
      Assert.AreEqual(5, test1.DetermineTotalPrice()); 
      Assert.AreEqual(10, test2.DetermineTotalPrice()); 
      Assert.AreEqual(10, test3.DetermineTotalPrice()); 
      Assert.AreEqual(15, test4.DetermineTotalPrice()); 
      Assert.AreEqual(30, test5.DetermineTotalPrice()); 
    } */ 
