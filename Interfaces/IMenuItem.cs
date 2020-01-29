namespace vendingMachine.Interfaces
{
  interface IMenuItem
  {
    string Name { get; set; }
    float Price { get; set; }

    string GetMenuLineItem();
  }
}