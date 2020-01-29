using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using vendingMachine.Models;

namespace vendingMachine.Services
{
  class VendingMachineService
  {


    //This will hold my data
    private Machine Machine { get; set; } = new Machine();

    //Collection of messages that will be drawn by the controller
    public List<string> Messages = new List<string>();


    public void PrintMenu()
    {
      int index = 1;
      foreach (var item in Machine.Menu)
      {

        Messages.Add(index.ToString() + ") " + item.GetMenuLineItem());
        index++;
      }


    }
  }
}