using System.Collections.Generic;  

namespace Bakery.Models{
  public class Order{

    private static List<Order> _orders = new List<Order> {}; 
    public string OrderName { get; set; }
    public string Description { get; set; }
    public int TotalPrice { get; set; } 
    public int DateInput { get; set; } 
    public int Id { get; }  

    public Order(string name, string description, int totalPrice, int d8) { 
      OrderName = name; 
      Description = description; 
      TotalPrice = totalPrice; 
      DateInput = d8; 
      _orders.Add(this);
      Id = _orders.Count; 
    } 




    public static List<Order> GetAll()  //'Getter' method
    {
//      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }

  }
}