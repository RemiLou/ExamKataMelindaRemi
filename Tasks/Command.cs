using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Tasks
{
    public abstract class Command
    {

        public abstract string Execute()
        {
            while (true)
            {

                console.Write("> ");
                var command = console.ReadLine();
                if (command == QUIT)
                {
                    break;
                }
                CommandType(command);
            }

            string commandRest = command.Split(" ".ToCharArray(), 2);
            string command = commandRest[0];

            return command;
        }

        public virtual void CommandType()
        { 
        
        }
    }
}
