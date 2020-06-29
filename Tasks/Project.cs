using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Project
    {
        List<Task> tasks = new List<Task>();

		private void AddTask(string project, string description)
		{
			if (!tasks.TryGetValue(project, out IList<Task> projectTasks))
			{
				Console.WriteLine("Could not find a project with the name \"{0}\".", project);
				return;
			}
			projectTasks.Add(new Task { Id = lastId.Id, Description = description, Done = false });
		}
	}
}
