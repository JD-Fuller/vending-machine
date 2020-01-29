using System;
using vendingMachine.Sercvices;


namespace vendingMachine.Controllers
{
  class VendingMachineController
  {
    //Instantiates a service
    private VendingMachineService Service { get; set; } = new VendingMachineService();
    //This is for the while loop to run the app
    private bool _running = true;

    //This is the method used to run the app
    public void Run()
    {
      //I print the menu at the beginning of the app
      Service.PrintMenu();
      //Start of the while loop
      while (_running)
      {
        //I print a message, then get an input
        PrintMessages();
        GetUserInput();
      }
      //I clear out the console
      Console.Clear();
      Console.WriteLine("Thanks for the cash");
    }

    //I get the input from the user
    private void GetUserInput()
    {
      var key = Console.ReadKey();
      Console.Clear();
      var keyChar = key.KeyChar;
      switch (keyChar)
      {
        case 'q':
          AddCredit();
          break;
        case 'n':
          ReturnCredit();
        default:
          System.Console.WriteLine("Invalid coinage kid - we only take quarters");
          Service.PrintMenu();
          break;
      }




    }

    private void ReturnCredit()
    {

    }

    private void AddCredit()
    {
      // int credit = 0;
      // return credit ++;

    }

    //My job is to print messages
    private void PrintMessages()
    {
      Console.WriteLine("Please make your selection by first inserting a quarter");
      Console.WriteLine("");
      Console.WriteLine("Press (q) to add a quarter to the machine");
      Console.WriteLine("");
      Console.WriteLine("Press (n) to quit and return quarters");

    }

  }
}