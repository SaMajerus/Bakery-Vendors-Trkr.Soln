using System.Collections.Generic;  

namespace Bakery.Models{
  public class Order{

    private static List<Order> _orders = new List<Order> {}; 
    public string OrderName { get; set; }
    public string Description { get; set; }
    public int TotalPrice { get; set; } 
    public int DateSubmitted { get; set; }  //Format:  MMDDYYYY
    public int DeliverBy { get; set; }  //Format: same as above
    public int Id { get; }  

    public Order(string name, string description, int totalPrice, int d8Added, int deadline) { 
      OrderName = name;  //i.e. '[Purpose of order]' 
      Description = description;  //Requested quantity of each Item 
      TotalPrice = totalPrice;  //Grand Total Price (based on 'Receipt' printout   from Console App program) 
      DateSubmitted = d8Added;  //Date the order was placed.
      DeliverBy = deadline;  //Date by which the order needs to be delivered. (Always at 6am, let's say) 
      _orders.Add(this); 
      Id = _orders.Count; 
    } 

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

  }
}