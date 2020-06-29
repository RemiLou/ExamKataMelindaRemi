using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Check : Command
    {
        private string Id;

        public Check(string id)
        {
            this.Id = id;
        }

        public override void CommandInput()
        {
            SetTaskStatus(Id, true);
        }
	}
}
