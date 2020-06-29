using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Add : Command
    {
		private string TypeToAdd;
		private string Name;
		private string Description;

		public Add(string typeToAdd, string name, string description)
		{
			this.TypeToAdd = typeToAdd;
			this.Name = name;
			this.Description = description;
		}

		public override void CommandInput()
		{
			if (TypeToAdd == "project")
				Program.projects.Add(new Project() { Name = Name, Tasks = new List<Task>() });
			else if (TypeToAdd == "task")
			{
				foreach (var project in Program.projects)
					if (project.Name == Name)
						project.AddTask(Description);
			}
		}
	}
}
