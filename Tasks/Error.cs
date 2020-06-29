using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Error : Command
    {
        public override void CommandInput(string command)
        {
            Program.console.WriteLine("I don't know what the command \"{0}\" is.", command);
        }
    }
}
