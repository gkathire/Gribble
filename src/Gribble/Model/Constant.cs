﻿using System;

namespace Gribble.Model
{
    public class Constant
    {
        private static readonly Random Random = new Random();

        public string Alias = string.Format("C{0}", Random.Next());
        public object Value;
    }
}
