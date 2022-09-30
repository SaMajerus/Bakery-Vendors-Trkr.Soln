using System.Collections.Generic;  

namespace Bakery.Models{
  public class Order{
    
    private static List<Order> _orders = new List<Order> {}; 
    public string OrderName { get; set; }
    public string Description { get; set; }
    public int totalPrice { get; set; } 
    public int DateInput { get; set; } 
    public int Id { get; } 
    // public int QtyBread { get; set; } 
    // public int QtyPastry { get; set; } 
    // public int BreadPrice { get; set; }
    // public int PastryPrice { get; set; } 
    public int Date { get; set; } 

/*
    public Order(string name, string description, int totalPrice, int d8) { /*
      OrderName = name; 
      QtyBread = qtyBread; 
      QtyPastry = qtyPastry; 
      BreadPrice = 5;  //Price IFF (if and only if) Quantity=1. 
      PastryPrice = 2;  //Price IFF (if and only if) Quantity=1. 
      _orders.Add(this);
      Id = _orders.Count; 
    } 
*/


/*
    public static List<Order> GetAll()  //'Getter' method
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
*/

  }
}