using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace DocumentsSecurity
{
    static class Verifier
    {
        private static string path = Path.GetDirectoryName(Path.GetDirectoryName(
            System.IO.Directory.GetCurrentDirectory())) + "\\bin\\Debug\\signatures\\";

        public static bool verify(Report report)
        {
            XmlSerializer serializer = new XmlSerializer(report.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, report);

            string fileName = path + "report" + report.Id + ".dat";

            return verify(memoryStream, fileName);
        }

        public static bool verify(Programmer programmer)
        {
            XmlSerializer serializer = new XmlSerializer(programmer.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, programmer);

            string fileName = path + "programmer" + programmer.Id + ".dat";

            return verify(memoryStream, fileName);
        }

        public static bool verify(Project project)
        {
            XmlSerializer serializer = new XmlSerializer(project.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, project);

            string fileName = path + "project" + project.Id + ".dat";

            return verify(memoryStream, fileName);
        }

        public static bool verify(Finance finance)
        {
            XmlSerializer serializer = new XmlSerializer(finance.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, finance);

            string fileName = path + "finance" + finance.Id + ".dat";

            return verify(memoryStream, fileName);
        }

        private static bool verify(MemoryStream memoryStream, string fileName)
        {
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] bytes = new byte[memoryStream.Length];
            memoryStream.Read(bytes, 0, (int)memoryStream.Length);

            try
            {
                BinaryReader binaryReader = new BinaryReader(new FileStream(fileName, FileMode.Create));
                string savedKey = binaryReader.ReadString();
                int length = binaryReader.ReadInt32();
                byte[] savedSignature = binaryReader.ReadBytes(length);
                DSACryptoServiceProvider crypto = new DSACryptoServiceProvider();
                crypto.FromXmlString(savedKey);
                return (crypto.VerifyData(bytes, savedSignature));
            } 
            catch (Exception)
            {
                throw new FileNotFoundException("This file doesn't exist! Verification is failed!");
            }
        }
    }
}
