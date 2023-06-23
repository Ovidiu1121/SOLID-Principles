﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Dependency_Inversion_Principle
{
    public class EventLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write a message in system's event viewer.
        }
    }
}
