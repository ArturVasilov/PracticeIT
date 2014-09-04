using System;

namespace DocumentsSecurity
{
    class XmlController
    {
        private string fileName;

        public XmlController(string fileName)
        {
            this.fileName = fileName;
        }

        public string FileName
        {
            get { return fileName; }
        }
    }
}
