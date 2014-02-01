using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class UserAttribute
    {
        private String name;
        private String type;
        private bool isRef; //по ссылке или по значению

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool IsRef
        {
            get { return isRef; }
            set { isRef = value; }
        }

        public UserAttribute(String name, String type, bool isRef)
        {
            Name = name;
            Type = type;
            IsRef = isRef;
        }

        public String toStringCSharp()
        {
            String attribute_toString = "";

            if (IsRef) attribute_toString += "ref ";
            attribute_toString += Type + " ";
            attribute_toString += Name;

            return attribute_toString;
        }

    }
}
