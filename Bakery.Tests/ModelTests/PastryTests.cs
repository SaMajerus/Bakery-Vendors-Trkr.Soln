using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  { 
    [TestMethod]
    public void DealApplies_CheckCompatabilityWithPastryDeal_False()
    {
      Pastry test = new Pastry(2); 
      Assert.AreEqual(false, test.DealApplies()); 
    }


    [TestMethod]
    public void DealApplies_UseBranchingToCheckPastryDealCompatability_True()
    {
      Pastry test2 = new Pastry(3);
      Assert.AreEqual(true, test2.DealApplies()); 
    }

    [TestMethod]
    public void DetermineTotalPrice_UseBranchingToMakeCalculationsBasedOnQuantity_Int()
    { 
      Pastry four = new Pastry(4); 
      Pastry five = new Pastry(5); 
      Pastry six = new Pastry(6); 
      Pastry seven = new Pastry(7);
      Pastry eight = new Pastry(8); 
      Assert.AreEqual(7, four.DetermineTotalPrice()); 
      Assert.AreEqual(9, five.DetermineTotalPrice()); 
      Assert.AreEqual(10, six.DetermineTotalPrice()); 
      Assert.AreEqual(12, seven.DetermineTotalPrice()); 
      Assert.AreEqual(14, eight.DetermineTotalPrice()); 
    }
  }
}
