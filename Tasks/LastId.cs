using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public class LastId
    {
        public LastId()
        {
            Id = 0;
        }

        public int Id { get => Id++; set { Id = value; } }
    }
}
