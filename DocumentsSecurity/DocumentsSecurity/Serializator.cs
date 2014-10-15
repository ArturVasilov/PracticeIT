using System;

using System.IO;
using System.Xml.Serialization;

namespace DocumentsSecurity
{
    public static class Serializator
    {
        private static string path = Path.GetDirectoryName(Path.GetDirectoryName(
            System.IO.Directory.GetCurrentDirectory())) + "\\bin\\Debug\\serializations\\";

        public static void serialize(Report report)
        {
            string fileName = path + "report" + report.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(report.GetType());
            serializer.Serialize(fileStream, report);
        }

        public static void serialize(Programmer programmer)
        {
            string fileName = path + "programmer" + programmer.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(programmer.GetType());
            serializer.Serialize(fileStream, programmer);
        }

        public static void serialize(Project project)
        {
            string fileName = path + "project" + project.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(project.GetType());
            serializer.Serialize(fileStream, project);
        }

        public static void serialize(Finance finance)
        {
            string fileName = path + "finance" + finance.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(finance.GetType());
            serializer.Serialize(fileStream, finance);
        }
    }
}
