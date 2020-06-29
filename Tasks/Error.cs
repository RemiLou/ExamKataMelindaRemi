using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Error : Command
    {
        private string Command;

        public Error(string Command)
        {
            this.Command = Command;
        }

        public override void CommandInput()
        {
            Program.console.WriteLine("I don't know what the command \"{0}\" is.", Command);
        }
    }
}
