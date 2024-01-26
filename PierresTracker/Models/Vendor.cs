using System.Collections.Generic;

namespace PierresTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static int nextId = 0;

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = nextId++;
      _instances.Add(this);
      Orders = new List<Order> ();
    }

    public static void ResetNextId()
    {
      nextId = 1;
    }
  }
}