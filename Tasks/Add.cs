using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Add : Command
    {
		private string TypeToAdd;

		public Add(string TypeToAdd)
		{
			this.Id = id;
		}

		public override void CommandInput(string command)
		{
			if (TypeToAdd == "project")
			{
				AddProject(Id);
			}
			else if (TypeToAdd == "task")
			{
				var projectTask = subcommandRest[1].Split(" ".ToCharArray(), 2);
				AddTask(projectTask[0], projectTask[1]);
			}
		}
	}
}
