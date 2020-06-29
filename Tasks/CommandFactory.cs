using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class CommandFactory
    {
		private void Execute(string command)
		{
			Command commandType;
			switch (command)
			{
				case "show":
					commandType = new Show();
					break;
				case "add":
					commandType = new Add();
					break;
				case "check":
					commandType = new Check();
					break;
				case "uncheck":
					commandType = new Uncheck();
					break;
				case "help":
					commandType = new Help();
					break;
				default:
					Error(command);
					break;
			}
		}
	}
}
