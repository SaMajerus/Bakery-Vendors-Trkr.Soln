using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  { 
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
    }  
  }
}