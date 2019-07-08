﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Functions.Cli.Common
{
    [Flags]
    public enum BuildOption
    {
        None, // will act as "func azure functionapp publish <appname> --no-build"
        Local, // will act as "func azure functionapp publish <appname>"
        Remote, // will act as "func azure functionapp publish <appname> --server-side-build"
        Container, // will act as "func azure functionapp publish <appname> --build-native-deps"
        Default // will trigger remote build if requirements.txt has content
    }
}
