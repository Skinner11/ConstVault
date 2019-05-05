using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVault
{
    class Patterns
    {
        /// <summary>
        /// Regexp for matching RGB colors with CSS syntax.
        /// </summary>
        /// <example>rgb(255,255,255)</example>
        public const string RGB = @"^rgb\(\s?([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\s?,\s?([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\s?,\s?([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\s?\)$";

        /// <summary>
        /// Regexp for matching RGBa colors with CSS syntax.
        /// </summary>
        /// <example>rgba(255,255,255,0.2)</example>
        public const string RGBA = @"^rgba\(\s*(-?\d+|-?\d*\.\d+(?=%))(%?)\s*,\s*(-?\d+|-?\d*\.\d+(?=%))(\2)\s*,\s*(-?\d+|-?\d*\.\d+(?=%))(\2)\s*,\s*(-?\d+|-?\d*.\d+)\s*\)$";

        /// <summary>
        /// Regexp for matching HEX colors with CSS syntax.
        /// </summary>
        /// <example>#0f0, 808020, #ffa500</example>
        public const string HEX = @"^\#?[0-f]{3}$|^\#?[0-f]{6}$";
    }
}
