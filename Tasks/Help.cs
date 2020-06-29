using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Help : Command
    {
        public override void CommandInput()
        {
            console.WriteLine("Commands:");
            console.WriteLine("  show");
            console.WriteLine("  add project <project name>");
            console.WriteLine("  add task <project name> <task description>");
            console.WriteLine("  check <task ID>");
            console.WriteLine("  uncheck <task ID>");
            console.WriteLine();
        }
    }
}
