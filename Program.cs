using System;
using System.Collections.Generic;
using vendingMachine.Controllers;
using vendingMachine.Models;
using vendingMachine.Interfaces;

namespace vendingMachine
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Clear();
      VendingMachineController vm = new VendingMachineController();
      vm.Run();




    }
  }
}
