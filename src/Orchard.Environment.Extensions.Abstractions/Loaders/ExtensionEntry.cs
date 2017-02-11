﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Orchard.Environment.Extensions.Loaders
{
    public class ExtensionEntry
    {
        public IExtensionInfo ExtensionInfo { get; set; }
        public Assembly Assembly { get; set; }
        public IEnumerable<Type> ExportedTypes => Assembly == null ? Enumerable.Empty<Type>() : Assembly.ExportedTypes;
        public bool IsError { get; set; }
    }
}