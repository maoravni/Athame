﻿using System;

namespace Athame.Plugin
{
    public class PluginLoadException : Exception
    {
        public string File { get; set; }

        public PluginLoadException(string message, string file) : base(message)
        {
            File = file;
        }
    }
}
