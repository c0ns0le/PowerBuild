﻿// Copyright (c) 2017 Pavol Kovalik. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PowerBuild.Logging
{
    using Microsoft.Build.Framework;

    public interface IPSLogger : ILogger
    {
        void Initialize(IPSEventSink psEventSink);
    }
}