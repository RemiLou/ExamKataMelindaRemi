using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Help : Command
    {
        public override void CommandInput()
        {
            Program.console.WriteLine("Commands:");
            Program.console.WriteLine("  show");
            Program.console.WriteLine("  add project <project name>");
            Program.console.WriteLine("  add task <project name> <task description>");
            Program.console.WriteLine("  check <task ID>");
            Program.console.WriteLine("  uncheck <task ID>");
            Program.console.WriteLine();
        }
    }
}
