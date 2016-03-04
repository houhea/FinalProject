using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final;

namespace Final
{
    class Toppings
    {
        //string [] toppings = new string [] {};

        static public string createToppings(string  _toppingsType)
        {
            
            var Final2 = new Form1();

            Final2.optionsArray[2] = _toppingsType;

            var toppingType = _toppingsType;

           // toppings.Add(_toppingsType);

            return toppingType;
        }
    }
}
