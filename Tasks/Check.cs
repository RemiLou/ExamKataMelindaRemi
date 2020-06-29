using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Check : Command
    {
        public override void CommandInput(int id, bool status)
        {
            Program.SetTaskStatus(id, status);
        }
	}
}
