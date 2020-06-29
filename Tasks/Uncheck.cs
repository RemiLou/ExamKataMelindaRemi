using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class Uncheck : Command
    {
		private int Id;

		public Uncheck(int id)
		{
			this.Id = id;
		}

		public override void CommandInput()
		{
			SetTaskStatus(Id, false);
		}
    }
}
