namespace vendingMachine.Models
{
  class Food
  {
    public string Name { get; set; }
    public float Price { get; set; }
    public string GetFoodLineItem()
    {
      return $"{Name} -- ${Price}";
    }
    public Food(string name, float price)
    {

    }
  }
}