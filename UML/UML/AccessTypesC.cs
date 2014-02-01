using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class AccessTypesC
    {
        public enum AccessTypes
        {
            ac_public,
            ac_protected,
            ac_private,
            ac_default
        }

        protected AccessTypes access;

        public AccessTypes Access
        {
            get { return access; }
            set { access = value; }
        }

        protected static String getAccessString(AccessTypes access)
        {
            switch (access)
            {
                case AccessTypes.ac_public:
                    return "public ";

                case AccessTypes.ac_protected:
                    return "protected ";

                case AccessTypes.ac_private:
                    return "private ";

                case AccessTypes.ac_default:
                    return "";

                default:
                    return "";
            }
        }

        public static AccessTypes valueOfString(String access_string)
        {
            switch (access_string)
            {
                case "default":
                    return AccessTypes.ac_default;

                case "public":
                    return AccessTypes.ac_public;

                case "protected":
                    return AccessTypes.ac_protected;

                case "private":
                    return AccessTypes.ac_private;

                default:
                    return AccessTypes.ac_public;
            }
        }
    }
}