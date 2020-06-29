using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Show : Command
    {
		public override void CommandInput()
		{
			foreach (var project in tasks)
			{
				console.WriteLine(project.Key);
				foreach (var task in project.Value)
				{
					console.WriteLine("    [{0}] {1}: {2}", (task.Done ? 'x' : ' '), task.Id, task.Description);
				}
				console.WriteLine();
			}
		}
    }
}
