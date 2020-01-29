using System;
using System.Collections.Generic;
using vendingMachine.Interfaces;

namespace vendingMachine.Models
{

  class VMachine
  {

    public List<IMenuItem> Menu { get; set; } = new List<IMenuItem>();
    private void Setup()
    {

      //create the data
      Food peanuts = new Food("Peanuts", 1.00f);
      Food crackers = new Food("Crackers", .75f);
      Food snickers = new Food("Snickers", .75f);
      Food mnm = new Food("M&M's", 1.00f);
      Menu.AddRange(new IMenuItem[]{
        peanuts, crackers, snickers, mnm
      });


    }
    public VMachine()
    {
      Setup();
    }

  }
}