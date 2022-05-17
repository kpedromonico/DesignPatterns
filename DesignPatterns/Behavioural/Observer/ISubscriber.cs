﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public interface ISubscriber
    {
        void NotifyNewsToEndUsers(string news);
    }
}
