using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
	public class Program
	{
		private const string QUIT = "quit";

		private readonly IDictionary<string, IList<Task>> tasks = new Dictionary<string, IList<Task>>();
		private readonly IConsole console;

		private LastId lastId = new LastId();

		public static void Main(string[] args)
		{
			new Program(new RealConsole()).Run();
		}

		public Program(IConsole console)
		{
			this.console = console;
		}

		public void Run()
		{
			while (true) {
				console.Write("> ");
				var command = console.ReadLine();
				if (command == QUIT) {
					break;
				}
				Execute(command);
			}
		}

		private void Execute(string commandLine)
		{
			var commandRest = commandLine.Split(" ".ToCharArray(), 2);
			var command = commandRest[0];

			CommandFactory commandType = new CommandFactory();
			var executeCommand = commandType.GetCommandType(command);

			executeCommand.CommandInput();
		}

		private void AddProject(string name)
		{
			tasks[name] = new List<Task>();
		}

		private void AddTask(string project, string description)
		{
			if (!tasks.TryGetValue(project, out IList<Task> projectTasks))
			{
				Console.WriteLine("Could not find a project with the name \"{0}\".", project);
				return;
			}
			projectTasks.Add(new Task { Id = LastId(), Description = description, Done = false });
		}

		private void SetDone(string idString, bool done)
		{
			int id = int.Parse(idString);
			var identifiedTask = tasks
				.Select(project => project.Value.FirstOrDefault(task => task.Id == id))
				.Where(task => task != null)
				.FirstOrDefault();
			if (identifiedTask == null) {
				console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			identifiedTask.Done = done;
		}

		private long LastId()
		{
			return lastId++;
		}
	}
}
