using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace DocumentsSecurity
{
    internal static class Signer
    {
        private static string path = Path.GetDirectoryName(Path.GetDirectoryName(
            System.IO.Directory.GetCurrentDirectory())) + "\\bin\\Debug\\signatures\\";

        internal static void sign(Report report)
        {
            XmlSerializer serializer = new XmlSerializer(report.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, report);

            string fileName = path + "report" + report.Id + ".dat";

            sign(memoryStream, fileName);
        }

        internal static void sign(Programmer programmer)
        {
            XmlSerializer serializer = new XmlSerializer(programmer.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, programmer);

            string fileName = path + "programmer" + programmer.Id + ".dat";

            sign(memoryStream, fileName);
        }

        internal static void sign(Project project)
        {
            XmlSerializer serializer = new XmlSerializer(project.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, project);

            string fileName = path + "project" + project.Id + ".dat";

            sign(memoryStream, fileName);
        }

        internal static void sign(Finance finance)
        {
            XmlSerializer serializer = new XmlSerializer(finance.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.Serialize(memoryStream, finance);

            string fileName = path + "finance" + finance.Id + ".dat";

            sign(memoryStream, fileName);
        }

        private static void sign(MemoryStream memoryStream, string fileName)
        {
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] bytes = new byte[memoryStream.Length];
            memoryStream.Read(bytes, 0, (int)memoryStream.Length);

            DSACryptoServiceProvider encryptor = new DSACryptoServiceProvider();
            byte[] signature = encryptor.SignData(bytes);
            string key = encryptor.ToXmlString(true);

            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(fileName, FileMode.Create));
            binaryWriter.Write(key);
            binaryWriter.Write(signature.Length);
            binaryWriter.Write(signature);
            binaryWriter.Close();
        }
    }
}
