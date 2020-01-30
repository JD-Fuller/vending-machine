using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using vendingMachine.Models;

namespace vendingMachine.Services
{
  class VendingMachineService
  {


    //This will hold my data
    private Vmachine VMachine { get; set; } = new Vmachine();

    //Collection of messages that will be drawn by the controller
    public List<string> Messages = new List<string>();


    public void PrintMenu()
    {
      int index = 1;
      foreach (var item in Vmachine.Menu)
      {

        Messages.Add(index.ToString() + ") " + item.GetMenuLineItem());
        index++;
      }
      Messages.Add("Press (insert button) for items purchase");


    }

    public void PurchaseFood(string name, float price)
    {
      Food newFood = new Food(name, price);
      Vmachine.Menu.Add(newFood);
      Messages.Add($"Successfully purchased {name}");
      PrintMenu();

    }
  }

  internal class Vmachine
  {
  }
}