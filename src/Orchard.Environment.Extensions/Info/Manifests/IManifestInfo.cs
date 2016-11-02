﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;

namespace Orchard.Environment.Extensions.Info
{
    public interface IManifestInfo
    {
        IFileInfo Manifest { get; }
        bool Exists { get; }
        string Name { get; }
        string Description { get; }
        string Type { get; }
        IConfigurationRoot ConfigurationRoot { get; }
    }
}