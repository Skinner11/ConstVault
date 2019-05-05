using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVault    
{
    //Definition of a single ConstElement's data structure
    class ConstElement
    {
        public enum Type
        {
            Text,
            URL,
            Path,
            RGB,
            RGBA,
            HEX            
        };

        ///<summary>Keeping track of the last issued ID, to prevent collisions</summary>
        private static ushort CurrentID = 0;
        ///<summary>Each one will have a unique ID</summary>
        private readonly ushort ID;

        ///<summary>Constructor for creating a single ConstElement</summary>
        ///<param name="displayName">The displayed name of the Const</param>
        ///<param name="value">The text value of the Const that can be copied by the user later</param>
        ///<param name="type">The type of the Const, which will allow us to display specific information apart from the name (like show the actual color for an RGB/HEX value)</param>
        public ConstElement(string displayName, string value, Type type)
        {            
            ID = ++CurrentID;
        }
    }
}
