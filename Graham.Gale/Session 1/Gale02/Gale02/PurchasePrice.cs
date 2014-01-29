using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gale02
{
        class CanRack
    {
        public int initialPrice;
        int _stock = 3;
        public void purchasePrice()
        {
             initialPrice = 55;
        }
        public int Stock
        {
            get
            {
                return _stock;
            }
        }
        public void CanRackMethod()
        {
                         int InsertedAmount;
            int TotalAmount = 0;
            purchasePrice();
            int Price = initialPrice;
            int action = 0;


              while (action != 5)
              {
              Console.WriteLine("Please select an action:");
              Console.WriteLine("1 Add to rack");
              Console.WriteLine("2 Fill Rack");
              Console.WriteLine("3 Empty rack");
              Console.WriteLine("4 Buy a soda");
              Console.WriteLine("5 Select another soda type");
              action = Convert.ToInt32(Console.ReadLine());
                  switch (action)
                  {
                      case 1:
                          if (_stock < 3)
                          _stock = _stock + 1;
                     else
                      Console.WriteLine("Rack already full");
                           Console.WriteLine("Rack now has {0}", _stock);
                          break;
                      case 2:
                          _stock = 3;
                          Console.WriteLine("You have filled the rack {0}", _stock);
                          break;
                      case 3:
                          _stock = 0;
                          Console.WriteLine("You have emptied {0}", _stock);
                          break;
                      case 4:
                          Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
                          while (TotalAmount < Price)
                          {
                              Console.Write("Please insert ");
                              Console.Write("{0}", (Price - TotalAmount));
                              Console.Write(" cents:");
                              InsertedAmount = Convert.ToInt32(Console.ReadLine());
                              TotalAmount = TotalAmount + InsertedAmount;
                              Console.Write("You have inserted {0}", TotalAmount);
                              Console.WriteLine(" cents");
                          } //end while
                          TotalAmount = 0;
                          _stock = _stock - 1;
                          Console.WriteLine("Thanks. Here is your soda.");
                          break;
                      case 5:
                          break;
                      default:
                          Console.WriteLine("Please try again, action not valid");
                          break;

                  }
              }

        }


        } //end of CanRackMethod

        } 
        

