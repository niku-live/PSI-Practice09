﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class StaticDataStorage
    {
        public static IDataStorage Data { get => new DefaultDataStorage(); }
    }
}
