using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
	public class Program
	{
		private const string QUIT = "quit";

		private List<Project> projects = new List<Project>();
		private readonly IConsole console;

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

		public void SetTaskStatus(string IdSearched, bool done)
		{
			int id = int.Parse(IdSearched);
			var task = projects
				.Select(project => project.Tasks.FirstOrDefault(task => task.Id == id))
				.FirstOrDefault();

			if (task == null) {
				console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			task.Done = done;
		}
	}
}
