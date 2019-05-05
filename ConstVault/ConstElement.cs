using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConstVault    
{
    ///<summary>Definition of a single ConstElement's data structure</summary>
    class ConstElement
    {
        public enum Type
        {
            Text,
            URL,
            Path,
            RGB,
            RGBA,
            HEX,
            Auto
        };

        ///<summary>Keeping track of the last issued ID, to prevent collisions</summary>
        private static ushort CurrentID = 0;
        ///<summary>Each one will have a unique ID</summary>
        private readonly ushort ID;
        ///<summary>Displayed name of the Const, does not have to be unique</summary>
        private string displayName;
        ///<summary>Type of the Const</summary>
        private Type type;

        ///<summary>Constructor for creating a single ConstElement</summary>
        ///<param name="displayName">The displayed name of the Const</param>
        ///<param name="value">The text value of the Const that can be copied by the user later</param>
        ///<param name="type">The type of the Const, which will allow us to display specific information apart from the name (like show the actual color for an RGB/HEX value)</param>
        public ConstElement(string displayName, string value, Type type)
        {            
            ID = CurrentID++;
            this.displayName = displayName;
            
            if (type == Type.Auto)
                this.type = AutoType(value);
            else
                this.type = type;
        }

        ///<summary>Automatic "type casting", if the type of the text was not specified</summary>
        ///<param name="value">The value which we'll try to parse into one of the Types</param>
        private Type AutoType(string value)
        {
            if (Regex.IsMatch(value, Patterns.RGB))
                return Type.RGB;
            if (Regex.IsMatch(value, Patterns.RGBA))
                return Type.RGBA;
            if (Regex.IsMatch(value, Patterns.HEX))
                return Type.HEX;
            if (Uri.IsWellFormedUriString(value, 0))
                return Type.URL;

            return Type.Text;
        }
    }
}
