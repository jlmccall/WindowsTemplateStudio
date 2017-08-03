﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Serialization;

using Microsoft.Templates.Core.Locations;
using Microsoft.Templates.Core.Resources;

namespace Microsoft.Templates.Core
{
    [Serializable]
    public class RepositorySynchronizationException : Exception
    {
        public RepositorySynchronizationException()
        {
        }

        public RepositorySynchronizationException(string message, Exception innerException = null) : base(message, innerException)
        {
        }

        protected RepositorySynchronizationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public RepositorySynchronizationException(SyncStatus status, Exception innerException = null) : base($"{StringRes.RepositorySynchronizationExceptionMessage} '{status}'", innerException)
        {
        }
    }
}
