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

    // public Order(string name, string description, int totalPrice, int d8){ 
    //   OrderName = name; 
    //   QtyBread = qtyBread; 
    //   QtyPastry = qtyPastry; 
    //   BreadPrice = 5;  //Price IFF (if and only if) Quantity=1. 
    //   PastryPrice = 2;  //Price IFF (if and only if) Quantity=1. 
    //   _orders.Add(this);
    //   Id = _orders.Count; 
    // } 





    // public Order(string name, int qtyBread, int qtyPastry){ 
    //   VendorName = name; 
    //   QtyBread = qtyBread; 
    //   QtyPastry = qtyPastry; 
    //   BreadPrice = 5;  //Price IFF (if and only if) Quantity=1. 
    //   PastryPrice = 2;  //Price IFF (if and only if) Quantity=1. 
    //   _orders.Add(this);
    //   Id = _orders.Count; 
    // } 

    // public static int GetGrandTotal(){
    //   int b = this.TotalBreadPrice();
    //   int p = this.TotalPastryPrice();
    //   return (b + p);
    // }

    // public bool DealApplies(int qty){ 
    //   if(qty >= 3){
    //     return true; 
    //   } else {
    //     return false;
    //   }
    // }

    // public int TotalBreadPrice(){ 
    //   int total = 0; 
    //   int remainingQty = 0;  //If -- after "B2G1" Deal is applied for >=1 group(s) of 3 -- the remaining Quantity is < 3, that num is saved here. 
    //   int numDealGroups=0;  //Saves result of 'QtyBread/3' if 'QtyBread%3 == 0'. (Number of Deal-applicable Item-triplets) 
    //   if (DealApplies()==true) { 
    //     if (QtyBread % 3 == 0) {
    //       numDealGroups=QtyBread/3; 
    //       remainingQty=0; 
    //       total += (2 * BasePrice * numDealGroups);
    //     } else {
    //       remainingQty = QtyBread%3; //Saves remainder of current QtyBread #. 
    //       QtyBread -= remainingQty; //Reduces 'QtyBread' to a # evenly-divisible by 3 (for calculation on next line). 
    //       numDealGroups = QtyBread/3; 
    //       total = (2 * BreadPrice * numDealGroups) + (BreadPrice * remainingQty);
    //     } 
    //   } else {
    //     total = (BreadPrice * QtyBread); 
    //   }
    //   return total; 
    // }

    // public int TotalPastryPrice(){ 
    //   int total = 0; 
    //   int remainingQty = 0;  //If -- after "B2G1" Deal is applied for >=1 group(s) of 3 -- the remaining Quantity is < 3, that num is saved here. 
    //   int numDealGroups=0;  //Saves result of 'QtyPastry/3' if 'QtyPastry%3 == 0'. (Number of Deal-applicable Item-triplets) 
    //   if (DealApplies(QtyPastry)==true) {  //Is true IFF QtyPastry >= 3. 
    //     if (QtyPastry % 3 == 0) {
    //       numDealGroups=QtyPastry/3; 
    //       remainingQty=0; 
    //       total += (5 * numDealGroups);
    //     } else {
    //       remainingQty = QtyPastry%3; //Saves remainder of current QtyPastry #. 
    //       QtyPastry -= remainingQty; //Reduces 'QtyPastry' to a # evenly-divisible by 3 (for calculation on next line). 
    //       numDealGroups = QtyPastry/3; 
    //       total = (5 * numDealGroups) + (PastryPrice * remainingQty);
    //     }  
    //   } else {
    //     total = (PastryPrice * QtyPastry); 
    //   } 
    //   return total;
    // }



    // public static List<Order> GetAll()  //'Getter' method
    // {
    //   return _orders;
    // }

    // public static void ClearAll()
    // {
    //   _orders.Clear();
    // }

    // public static Order Find(int searchId)
    // {
    //   return _orders[searchId-1];
    // }
    
  }
}