using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Food : IMenuItem
  {
    public string Name { get; set; }
    public float Price { get; set; }

    public string GetMenuLineItem()
    {
      return $"{Name} -- ${Price}";
    }

    public Food(string name, float price)
    {
      Name = name;
      Price = price;

    }
  }
}