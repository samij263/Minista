﻿using System;
using Windows.UI;
using Windows.UI.Xaml.Media;
using UICompositionAnimations.Behaviours;
using UICompositionAnimations.Brushes.Base;

namespace UICompositionAnimations.Brushes
{
    /// <summary>
    /// A <see cref="XamlCompositionBrush"/> that implements an acrylic effect with customizable parameters
    /// </summary>
    public sealed class AcrylicBrush : XamlCompositionEffectBrushBase
    {
        /// <summary>
        /// Gets or sets the source mode for the effect
        /// </summary>
        public AcrylicBackgroundSource Source { get; set; }

        /// <summary>
        /// Gets or sets the blur amount for the effect
        /// </summary>
        /// <remarks>This property is ignored when the active mode is <see cref="AcrylicBackgroundSource.HostBackdrop"/></remarks>
        public double BlurAmount { get; set; }

        /// <summary>
        /// Gets or sets the tint for the effect
        /// </summary>
        public Color Tint { get; set; }

        /// <summary>
        /// Gets or sets the color for the tint effect
        /// </summary>
        public double TintMix { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Uri"/> to the texture to use
        /// </summary>
        public Uri TextureUri { get; set; }

        /// <inheritdoc/>
        protected override PipelineBuilder OnBrushRequested()
        {
            switch (Source)
            {
                case AcrylicBackgroundSource.Backdrop: return PipelineBuilder.FromBackdropAcrylic(Tint, (float)TintMix, (float)BlurAmount, TextureUri);
                case AcrylicBackgroundSource.HostBackdrop: return PipelineBuilder.FromHostBackdropAcrylic(Tint, (float)TintMix, TextureUri);
                default: throw new ArgumentOutOfRangeException(nameof(Source), $"Invalid acrylic source: {Source}");
            }
        }
    }
}
