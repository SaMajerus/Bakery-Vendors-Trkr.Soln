using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    //private static List<Vendor> _vendors = new List<Vendor> {}; 
    public string VendorName { get; set; }
    public int Id { get; }
    //public List<Order> Orders { get; set; }
    public List<Order> Orders = new List<Order> {}; 
/*
    public Vendor(string name) {
      VendorName = name;
      _vendors.Add(this);
      Id = _vendors.Count;
      //Orders = new List<Order> {};
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
