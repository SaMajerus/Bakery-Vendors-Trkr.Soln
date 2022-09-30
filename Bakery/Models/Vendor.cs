using System.Collections.Generic;

namespace Bakery.Models{
  public class Vendor{ 

    private static List<Vendor> _vendors = new List<Vendor> {}; 
    public string VendorName { get; set; } 
    public string VendorDesc { get; set; }  
    public List<Order> Orders { get; set; }  
    public int Id { get; }

/*
    public Vendor(string name, string desc) { /*
      VendorName = name;
      VendorDesc = desc;
      _vendors.Add(this);
      Id = _vendors.Count; 
      Orders = new List<Order> {};  //Fully initializes the List here, so it's ready to accept Order objects as soon as the constructor is done, at the earliest. 
    }

    public static void ClearAll() {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll() {
      return _vendors;
    }

    public static Vendor Find(int searchId) {
      return _vendors[searchId-1];
    }

    public void AddVendor(Vendor ven) {
      Vendors.Add(ven);
    }*/
  }
}
