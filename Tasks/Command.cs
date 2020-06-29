using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Tasks
{
    public abstract class Command
    {

        public virtual void CommandInput(params object[] parameters)
        { 
        
        }
    }
}
