﻿// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/matkoch/Nuke/blob/master/LICENSE

using System;
using System.IO;
using System.Linq;

namespace Nuke.Core
{
    public static partial class EnvironmentInfo
    {
        public static string NewLine => Environment.NewLine;
        public static string MachineName => Environment.MachineName;

        public static string CurrentDirectory =>
#if NETCORE
                Directory.GetCurrentDirectory();
#else
                Environment.CurrentDirectory;
#endif
    }
}
