﻿
namespace UICompositionAnimations.Enums
{
    /// <summary>
    /// An <see langword="enum"/> that indicates the framework layer to target in a specific animation
    /// </summary>
    public enum FrameworkLayer
    {
        /// <summary>
        /// Indicates the <see cref="Windows.UI.Composition"/> APIs
        /// </summary>
        Composition,

        /// <summary>
        /// Indicates the <see cref="Windows.UI.Xaml.Media.Animation"/> APIs
        /// </summary>
        Xaml
    }
}