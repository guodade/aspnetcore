// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Testing.xunit;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;

[assembly: ShortClassName]
[assembly: LogLevel(LogLevel.Trace)]
[assembly: OSSkipCondition(OperatingSystems.MacOSX, SkipReason = "https://github.com/aspnet/AspNetCore/issues/8164")]
