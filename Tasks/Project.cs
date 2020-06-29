using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Project
    {
		private LastId lastId = new LastId();

		public string Name { get; set; }

		public List<Task> Tasks = new List<Task>();

		public void AddTask(string description)
		{
			Tasks.Add(new Task { Id = lastId.Id, Description = description, Done = false });
		}
	}
}
