using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Check : Command
    {
        public override void CommandInput(params object[] parameters)
        {
            Program.SetTaskStatus(parameters[0].ToString(), Convert.ToBoolean(parameters[1]));
        }
	}
}
