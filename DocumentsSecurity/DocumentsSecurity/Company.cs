using System;

namespace DocumentsSecurity
{
    class Company
    {
        public static const string FILENAME = "alldocuments.xml";

        private XmlController xml;

        //TODO : add lists of workers, finance and documents types

        private static volatile Company instance;
        private static object syncRoot = new Object();

        private Company() 
        {
            //TODO : change to XmlSecurityWrapper
            xml = new XmlController(FILENAME);
        }

        public static Company Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Company();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
