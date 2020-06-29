using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Project
    {
		private LastId lastId = new LastId();

		public string Name { get; set; }

		private List<Task> tasks = new List<Task>();

		private void AddTask(string description)
		{
			tasks.Add(new Task { Id = lastId.Id, Description = description, Done = false });
		}
	}
}
