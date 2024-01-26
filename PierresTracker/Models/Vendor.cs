namespace PierresTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; set; }
    private static int nextId = 0;
    
    public Vendor(string name)
    {
      Name = name;
      Id = nextId++;
    }

    public static void ResetNextId()
    {
      nextId = 1;
    }
  }
}