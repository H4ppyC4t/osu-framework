﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Threading.Tasks;

namespace osu.Framework.Text
{
    public interface ITexturedGlyphLookupStore
    {
        /// <summary>
        /// Retrieves a glyph from the store.
        /// </summary>
        /// <param name="fontName">The name of the font. Alternatively, a suffix of the name can be provided to search for the nearest font matching the given suffix.
        /// This is used to look up a glyph in any font while requiring certain weight / italics specifications.</param>
        /// <param name="character">The character to retrieve.</param>
        /// <returns>The character glyph.</returns>
        ITexturedCharacterGlyph? Get(string? fontName, char character);

        /// <summary>
        /// Retrieves a glyph from the store asynchronously.
        /// </summary>
        /// <param name="fontName">The name of the font. Alternatively, a suffix of the name can be provided to search for the nearest font matching the given suffix.
        /// This is used to look up a glyph in any font while requiring certain weight / italics specifications.</param>
        /// <param name="character">The character to retrieve.</param>
        /// <returns>The character glyph.</returns>
        Task<ITexturedCharacterGlyph?> GetAsync(string fontName, char character);
    }
}
