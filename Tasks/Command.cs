using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Tasks
{
    public abstract class Command
    {

        string commandRest = commandLine.Split(" ".ToCharArray(), 2);
        string command = commandRest[0];

        public virtual void CommandType()
        { 
        
        }
    }
}
