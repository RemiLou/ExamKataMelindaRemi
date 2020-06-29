using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Uncheck : Command
    {
		public override void CommandInput(string id)
		{
			SetTaskStatus(id, false);
		}
    }
}
