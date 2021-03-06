﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tasks
{
    public class CommandFactory
    {
		public Command GetCommandType(string[] commandText)
		{
			Command commandType;
			switch (commandText[0]) // Type
			{
				case "show":
					commandType = new Show();
					break;
				case "add":
					var param = commandText[1].Split(" ".ToCharArray(), 2);
					commandType = new Add(param[0], param[1].Split(" ".ToCharArray(), 2)[0], param[1].Split(" ".ToCharArray(), 2)[1]); // Param Type + Name + Description
					break;
				case "check":
					commandType = new Check(commandText[1]); // Param
					break;
				case "uncheck":
					commandType = new Uncheck(commandText[1]); // Param
					break;
				case "help":
					commandType = new Help();
					break;
				default:
					commandType = new Error(commandText);
					break;
			}

			return commandType;
		}
	}
}
