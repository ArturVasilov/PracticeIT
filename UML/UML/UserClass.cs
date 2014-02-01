using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class UserClass : AccessTypesC
    {
        private String class_name;
        private bool isStatic;
        private bool isAbstract;

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
        public bool IsAbstract
        {
            get { return isAbstract; }
            set { isAbstract = value; }
        }

        public UserClass(String class_name, bool iStatic, bool isAbstract,
            AccessTypes access, Method[] methods, Field[] fields)
        {
            Class_name = Formating.formatClassName(class_name);
            IsStatic = iStatic;
            IsAbstract = isAbstract;
            Access = access;

            foreach (Method method in methods)
                this.methods.Add(method);

            foreach (Field field in fields)
                this.fields.Add(field);
        }

        public UserClass(String class_name, bool iStatic, bool isAbstract,
            AccessTypes access)
        {
            Class_name = Formating.formatClassName(class_name);
            IsStatic = iStatic;
            IsAbstract = isAbstract;
            Access = access;
        }

        public void addField(Field adding_field)
        {
            fields.Add(adding_field);
        }

        public void addMethod(Method adding_method)
        {
            methods.Add(adding_method);
        }

        public String[] toStringCSharp()
        {
            int stringsCount = 1 + 1 + 1 + methods.Count * 5 + fields.Count * 2 + 1;
            //без геттеров и конструктора
            String[] class_toString = new String[stringsCount];

            class_toString[0] += getAccessString(Access);
            if (IsStatic) class_toString[0] += "static ";
            if (IsAbstract) class_toString[0] += "abstract ";
            class_toString[0] += "class ";
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
