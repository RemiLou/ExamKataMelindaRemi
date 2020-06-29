using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Tasks
{
    public abstract class Command
    { 
        public virtual void CommandInput(string id)
        { 
        
        }
		public virtual void CommandInput()
		{

		}

		protected void SetTaskStatus(string IdSearched, bool done)
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
