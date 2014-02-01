using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UML
{
    class TestDatasClass
    {
        private const int COUNT = 3;

        Field[] field = new Field[COUNT];
        UserAttribute[] usa = new UserAttribute[COUNT];
        Method[] meth = new Method[COUNT];

        public TestDatasClass()
        {
            for (int i = 0; i < COUNT; i++)
            {
                field[i] = new Field("field" + i, "int", i % 3 == 1,
                    false, AccessTypesC.AccessTypes.ac_protected);

                usa[i] = new UserAttribute("attr" + i, "double", i % 2 == 0);
            }

            for (int i = 0; i < COUNT; i++)
            {
                meth[i] = new Method("method" + i, i % 3 == 0, false, "void",
                    AccessTypesC.AccessTypes.ac_public, usa);
            }
        }

        public void testMethod()
        {
            StreamWriter sw = new StreamWriter("ppp.txt");
            String[] fields = new String[COUNT];
            String[][] method = new String[COUNT][];
            for (int i = 0; i < COUNT; i++)
            {
                fields[i] = field[i].toStringCSharp();
                method[i] = meth[i].toStringCSharp();
            }

            UserClass uc = new UserClass("MyClass", false, true,
                AccessTypesC.AccessTypes.ac_public, meth, field);

            String[] writing = uc.toStringCSharp();
            for (int i = 0; i < writing.Length; i++)
            {
                sw.WriteLine(writing[i]);
            }
            sw.Close();
        }

    }
}

