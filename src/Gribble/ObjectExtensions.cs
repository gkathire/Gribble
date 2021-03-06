﻿using System;

namespace Gribble
{
    public static class ObjectExtensions
    {
         public static T FromDb<T>(this object value)
         {
             return value == DBNull.Value ? default(T) : (T) value;
         }
    }
}