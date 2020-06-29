using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Check : Command
    {
        public override void CommandInput(string id)
        {
            SetTaskStatus(id, true);
        }
	}
}
