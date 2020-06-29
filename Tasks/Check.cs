using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Check : Command
    {
        public override void CommandInput(params object[] parameters)
        {
            Program.SetTaskStatus(parameters[0].ToString(), Convert.ToBoolean(parameters[1]));
        }

		public void SetTaskStatus(string IdSearched, bool done)
		{
			int id = int.Parse(IdSearched);
			var task = Program.projects
				.Select(project => project.Tasks.FirstOrDefault(task => task.Id == id))
				.FirstOrDefault();

			if (task == null)
			{
				Program.console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			task.Done = done;
		}
	}
}
