﻿using AdapterDependencyInjection.Interfaces;
using static System.Console;

namespace AdapterDependencyInjection
{
    public class Button
    {
        private ICommand command;
        private string name;

        public Button(ICommand command, string name)
        {
            this.command = command;
            this.name = name;
        }

        public void Click()
        {
            command.Execute();
        }

        public void PrintMe()
        {
            WriteLine($"I am a button called {name}");
        }
    }
}
