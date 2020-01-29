namespace vendingMachine.Models
{

  class Machine
  {

    public List<IMenuItem> Menu { get; set; } = new List<IMenuItem>();
    private void Setup()
    {

      //create the data
      Food peanuts = new Food("Peanuts", new string[])
    }
  }
}