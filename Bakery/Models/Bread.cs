using System;

/*     Business Logic ('Bread')     */ 
namespace Bakery
{ 
  public class Bread{
    public int Quantity {get; set;} 
    public int BasePrice {get; set;}

    public Bread(int quantity){
      Quantity = quantity; 
      BasePrice = 5;  //Price IFF (if and only if) Quantity=1.
    }

    public bool DealApplies(){ 
      if(Quantity >= 3){
        return true;
      } else {
        return false;
      }
    }

    public int DetermineTotalPrice(){ 
      int total = 0; 
      int remainingQty = 0;  //If -- after "B2G1" Deal is applied for >=1 group(s) of 3 -- the remaining Quantity is < 3, that num is saved here. 
      int numDealGroups=0;  //Saves result of 'Quantity/3' if 'Quantity%3 == 0'. (Number of Deal-applicable Item-triplets) 
      if (this.DealApplies()==true) { 
        if (Quantity % 3 == 0) {
          numDealGroups=Quantity/3; 
          remainingQty=0; 
          total += (2 * BasePrice * numDealGroups);
        } else {
          remainingQty = Quantity%3; //Saves remainder of current Quantity #. 
          Quantity -= remainingQty; //Reduces 'Quantity' to a # evenly-divisible by 3 (for calculation on next line). 
          numDealGroups = Quantity/3; 
          total = (2 * BasePrice * numDealGroups) + (BasePrice * remainingQty);
        } 
      } else {
        total = (BasePrice * Quantity); 
      }
      return total; 
    } 
  }
}
