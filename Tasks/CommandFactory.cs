using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tasks
{
    public class CommandFactory
    {
		public Command GetCommandType(string command)
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
					commandType = new Error();
					break;
			}

			return commandType;
		}
	}
}
