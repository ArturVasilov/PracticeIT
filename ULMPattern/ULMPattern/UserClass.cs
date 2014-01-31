using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMPattern
{
    class UserClass : AccessTypesC
    {
        private String class_name;
        private bool isStatic;
        private bool isVirtual;

        List<Method> methods = new List<Method>();
        List<Field> fields = new List<Field>();

        public String Class_name
        {
            get { return class_name; }
            set { class_name = value; }
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

        public UserClass(String class_name, bool iStatic, bool isVirtual, 
            AccessTypes access, Method[] methods, Field[] fields)
        {
            Class_name = class_name;
            FormateClassName();
            IsStatic = iStatic;
            IsVirtual = isVirtual;
            Access = access;

            foreach (Method method in methods)
                this.methods.Add(method);

            foreach (Field field in fields)
                this.fields.Add(field);
        }

        public String[] toStringCSharp()
        {
            int stringsCount = 1 + 1 + 1 + methods.Count * 5 + fields.Count * 2 + 1;
            String[] class_toString = new String[stringsCount];

            class_toString[0] += getAccessString(Access);
            if (IsStatic) class_toString[0] += "static ";
            if (IsVirtual) class_toString[0] += "virtual ";
            class_toString[0] += Class_name;

            class_toString[1] = "{";
            class_toString[2] = "";

            int i = 3;

            for (int j = 0; j < fields.Count; i += 2, j++)
            {
                class_toString[i] = fields[j].toStringCSharp();
                class_toString[i + 1] = "";
            }

            for (int j = 0; j < methods.Count; i += 5, j++)
            {
                String[] curr_method = new String[4];
                curr_method = methods[j].toStringCSharp();
                class_toString[i] = curr_method[0];
                class_toString[i + 1] = curr_method[1];
                class_toString[i + 2] = curr_method[2];
                class_toString[i + 3] = curr_method[3];
                class_toString[i + 4] = "";
            }

            class_toString[i] = "}";

            return class_toString;
        }
       
    }
}
