﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace leaddoubler.CustomControls
{
    public class FontAwesomeIcon:Label
    {
        //Must match the exact "Name" of the font which you can get by double clicking the TTF in Windows
        public const string Typeface = "FontAwesome";

        public FontAwesomeIcon(string fontAwesomeIcon = null)
        {
            FontFamily = Typeface;    //iOS is happy with this, Android needs a renderer to add ".ttf"
            Text = fontAwesomeIcon;
        }

        /// <summary>
        /// Get more icons from http://fortawesome.github.io/Font-Awesome/cheatsheet/
        /// Tip: Just copy and past the icon picture here to get the icon
        /// </summary>
        public static class Icon
        {
            public static readonly string User = "";
            public static readonly string File = "";
            public static readonly string CaretDown = "";
        }
    }
}
