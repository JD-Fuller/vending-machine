using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using vendingMachine.Models;

namespace vendingMachine.Services
{
  class VendingMachineService
  {


    //This will hold my data
    private VMachine VMachine { get; set; } = new VMachine();

    //Collection of messages that will be drawn by the controller
    public List<string> Messages = new List<string>();


    public void PrintMenu()
    {
      int index = 1;
      foreach (var item in VMachine.Menu)
      {

        Messages.Add(index.ToString() + ") " + item.GetMenuLineItem());
        index++;
      }
      Messages.Add("Press (insert button) for items purchase");


    }

    public void PurchaseFood(string name, float price)
    {
      Food newFood = new Food(name, price);
      VMachine.Menu.Add(newFood);
      Messages.Add($"Successfully purchased {name}");
      PrintMenu();

    }
  }

  internal class VMachine
  {
  }
}