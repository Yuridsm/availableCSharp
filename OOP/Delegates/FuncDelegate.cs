﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.OOP.Delegates
{
    public class FuncDelegate
    {
        public static Func<string, string> selector = (string str) => str.ToLower();

    }
}
