using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMPattern
{
    class Field : AccessTypesC
    {
        private String field_name;

        private String type;
        private bool isConst;
        private bool isStatic;

        public String Field_name
        {
            get { return field_name; }
            set { field_name = value; }
        }
        public String Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool IsConst
        {
            get { return isConst; }
            set { isConst = value; }
        }
        public bool IsStatic
        {
            get { return isStatic; }
            set { isStatic = value; }
        }

        public Field(String field_name, String type, bool isConst,
            bool isStatic, AccessTypes access)
        {
            Field_name = field_name;
            Type = type;
            IsConst = isConst;
            IsStatic = isStatic;
            Access = access;
        }

        public String toStringCSharp()
        {
            String field_toString = "\t";

            field_toString += getAccessString(Access);
            if (IsStatic) field_toString += "static ";
            if (IsConst) field_toString += "const ";
            field_toString += Type + " ";
            field_toString += Field_name;
            field_toString += ";";

            return field_toString;
        }
    }
}
