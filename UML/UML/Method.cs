using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Method : AccessTypesC
    {
        private const int METHOD_STRING_COUNT = 4;

        private String method_name;

        //Будет 2 варианта создания аттрибутов, просто перечислить их или через массив
        private String attributes_string = "";
        List<UserAttribute> attributes = new List<UserAttribute>();

        private bool isStatic;
        private bool isVirtual;
        private String return_type;

        public String Method_name
        {
            get { return method_name; }
            set { method_name = value; }
        }
        public bool IsStatic
        {
            get { return isStatic; }
            set { isStatic = value; }
        }
        public bool IsVirtual
        {
            get { return isVirtual; }
            set { isVirtual = value; }
        }
        public String Return_type
        {
            get { return return_type; }
            set { return_type = value; }
        }

        public Method(String method_name, bool isStatic, bool isVirtual, String return_type,
            AccessTypes access, UserAttribute[] adding_attributes)
        {
            Method_name = method_name;
            IsStatic = isStatic;
            IsVirtual = isVirtual;
            Return_type = return_type;
            Access = access;
            foreach (UserAttribute adding_attribute in adding_attributes)
                attributes.Add(adding_attribute);
        }

        public Method(String method_name, bool isStatic, bool isVirtual, String return_type,
            AccessTypes access)
        {
            Method_name = method_name;
            IsStatic = isStatic;
            IsVirtual = isVirtual;
            Return_type = return_type;
            Access = access;
        }

        public void addAttribute(UserAttribute attribute)
        {
            attributes.Add(attribute);
        }

        public void createStringOfAttributes(String string_attributes)
        {
            attributes_string = "(";
            attributes_string += string_attributes;
            attributes_string += ")";
        }

        public String[] toStringCSharp()
        {
            String[] method_toString = new String[METHOD_STRING_COUNT];

            method_toString[0] += "\t" + getAccessString(Access);
            if (IsStatic) method_toString[0] += "static ";
            if (IsVirtual) method_toString[0] += "virtual ";
            method_toString[0] += Return_type + " ";
            method_toString[0] += Method_name;

            if (attributes.Count > 0)
                method_toString[0] += writeAttributes();
            else method_toString[0] += attributes_string;

            method_toString[1] += "\t" + "{";

            method_toString[2] = "\t\t" + "//Auto-generated method, please remake it";

            method_toString[3] = "\t" + "}";

            return method_toString;
        }

        public String writeAttributes()
        {
            String attr = "(";

            int n = attributes.Count;
            for (int i = 0; i < n - 1; i++)
            {
                attr += attributes[i].toStringCSharp();
                attr += ", ";
            }
            attr += attributes[n - 1].toStringCSharp();

            attr += ")";

            return attr;
        }
    }
}
