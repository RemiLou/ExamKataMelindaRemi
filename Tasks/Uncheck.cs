using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Uncheck : Command
    {
		private string Id;

		public Uncheck(string id)
		{
			this.Id = id;
		}

		public override void CommandInput()
		{
			SetTaskStatus(Id, false);
		}
    }
}
