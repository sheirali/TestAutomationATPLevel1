﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp.Classes
{
    public class Child : Person
    {
        public Child(string name, int age) 
            : base(name, age)
        {
        }

        public override int Age 
        { 
            get
            {
                return base.Age; 
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("The age for children cannot be > 15.");
                }
                
                base.Age = value; 
            }
        }
    }
}
