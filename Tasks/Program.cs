﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
	public static class Program
	{
		private const string QUIT = "quit";

		public static List<Project> projects = new List<Project>();
		public static IConsole console;

		public static void Main(string[] args)
		{
			console = new RealConsole();
			Program.Run();
		}

		public static void Run()
		{
			while (true) {
				console.Write("> ");
				var command = console.ReadLine();
				if (command == QUIT) {
					break;
				}
				Program.Execute(command);
			}
		}

		private static void Execute(string commandLine)
		{
			var commandText = commandLine.Split(" ".ToCharArray(), 2);

			CommandFactory commandType = new CommandFactory();
			var executeCommand = commandType.GetCommandType(commandText);

			executeCommand.CommandInput();
		}
	}
}
