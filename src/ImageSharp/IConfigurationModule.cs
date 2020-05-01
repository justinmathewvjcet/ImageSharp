﻿// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Represents an interface that can register image encoders, decoders and image format detectors.
    /// </summary>
    public interface IConfigurationModule
    {
        /// <summary>
        /// Called when loaded into a configuration object so the module can register items into the configuration.
        /// </summary>
        /// <param name="configuration">The configuration that will retain the encoders, decodes and mime type detectors.</param>
        void Configure(Configuration configuration);
    }
}