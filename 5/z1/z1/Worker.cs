﻿namespace ZavodNamespace
{
    public abstract class Worker
    {
        public string Name { get; set; }

        public Worker(string name)
        {
            Name = name;
        }

        public abstract void DoWork();
    }
}
