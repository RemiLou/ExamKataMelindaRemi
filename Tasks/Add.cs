using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Add : Command
    {
		public override void CommandInput()
		{
			var subcommandRest = commandLine.Split(" ".ToCharArray(), 2);
			var subcommand = subcommandRest[0];
			if (subcommand == "project")
			{
				AddProject(subcommandRest[1]);
			}
			else if (subcommand == "task")
			{
				var projectTask = subcommandRest[1].Split(" ".ToCharArray(), 2);
				AddTask(projectTask[0], projectTask[1]);
			}
		}
	}
}
