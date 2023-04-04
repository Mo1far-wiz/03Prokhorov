﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _03Prokhorov.Model.CustomException
{
    internal class AgeTooHighException : Exception
    {
        public AgeTooHighException(string message) : base(message)
        {
            MessageBox.Show("too old");
        }
    }
}
