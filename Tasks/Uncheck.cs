using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Uncheck : Command
    {

        public override void CommandInput()
        {
			int id = int.Parse(idString);
			var identifiedTask = tasks
				.Select(project => project.Value.FirstOrDefault(task => task.Id == id))
				.Where(task => task != null)
				.FirstOrDefault();
			if (identifiedTask == null)
			{
				console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			identifiedTask.Done = done;
		}
    }
}
