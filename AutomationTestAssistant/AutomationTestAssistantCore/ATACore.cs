﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestAssistantCore
{
    public static class ATACore
    {
        public static ProjectWorker Project 
        {
            get
            {
                return new ProjectWorker();
            }
        }

        public static Utilities Utilities
        {
            get
            {
                return new Utilities();
            }
        }

        public static TestExecution TestExecution
        {
            get
            {
                return new TestExecution();
            }
        }

        public static CommandLine CommandLine
        {
            get
            {
                return new CommandLine();
            }
        }

        public static CommandExecutor CommandExecutor
        {
            get
            {
                return new CommandExecutor();
            }
        }

        public static TcpWrapperProcessor TcpWrapperProcessor
        {
            get
            {
                return new TcpWrapperProcessor();
            }
        }

        public static Managers Managers
        {
            get
            {
                return new Managers();
            }
        }

        public static RegistryManager RegistryManager
        {
            get
            {
                return new RegistryManager();
            }
        }
    }
}
