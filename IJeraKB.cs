﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeraKeyboard
{
    public interface IJeraKB
    {
        void Init(string? path);
        void Toggle(bool value);
        bool IsActive();

        bool IsConfigExists();

        void OverridePath(string path);
    }
}
