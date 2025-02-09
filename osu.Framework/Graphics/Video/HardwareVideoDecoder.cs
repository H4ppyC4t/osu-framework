﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace osu.Framework.Graphics.Video
{
    /// <summary>
    /// Represents a list of usable hardware video decoders.
    /// </summary>
    /// <remarks>
    /// Contains decoders for ALL platforms.
    /// </remarks>
    [Flags]
    // todo: revisit when we have a way to exclude enum members from naming rules
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum HardwareVideoDecoder
    {
        /// <summary>
        /// Disables hardware decoding.
        /// </summary>
        [Description("None")]
        None,

        /// <remarks>
        /// Windows and Linux only.
        /// </remarks>
        [Description("Nvidia NVDEC (CUDA)")]
        NVDEC = 1,

        /// <summary>
        /// Windows and Linux only.
        /// </summary>
        [Description("Intel Quick Sync Video")]
        QuickSyncVideo = 1 << 2,

        /// <remarks>
        /// Windows only.
        /// </remarks>
        [Description("DirectX Video Acceleration 2.0")]
        DXVA2 = 1 << 3,

        /// <remarks>
        /// Linux only.
        /// </remarks>
        [Description("VDPAU")]
        VDPAU = 1 << 4,

        /// <remarks>
        /// Linux only.
        /// </remarks>
        [Description("VA-API")]
        VAAPI = 1 << 5,

        /// <remarks>
        /// Android only.
        /// </remarks>
        [Description("Android MediaCodec")]
        MediaCodec = 1 << 6,

        /// <remarks>
        /// Apple devices only.
        /// </remarks>
        [Description("Apple VideoToolbox")]
        VideoToolbox = 1 << 7,

        /// <remarks>
        /// Windows only.
        /// </remarks>
        [Description("Direct3D 11 Video Acceleration")]
        D3D11VA = 1 << 8,

        [Description("Any")]
        Any = int.MaxValue,
    }
}
