﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalDemo
{
    internal class IncorrectValueException : Exception
    {
        
        public IncorrectValueException() { }
        public IncorrectValueException(string message) : base(message) { }
    }
}
 
