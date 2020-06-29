using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Show : Command
    {
		public override void CommandInput()
		{
			foreach (var project in Program.projects)
			{
				Program.console.WriteLine(project.Name);
				foreach (var task in project.Tasks)
				{
					Program.console.WriteLine("    [{0}] {1}: {2}", (task.Done ? 'x' : ' '), task.Id, task.Description);
				}
				Program.console.WriteLine();
			}
		}
    }
}
