﻿using static System.Console;

namespace AbstractFactory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This coffee is sensational!");
        }
    }
}
