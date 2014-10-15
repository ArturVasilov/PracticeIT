using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace DocumentsSecurity
{
    public static class Serializator
    {
        public static void serialize(Report report)
        {
            string fileName = "report" + report.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(report.GetType());
            serializer.Serialize(fileStream, report);
        }

        public static void serialize(Programmer programmer)
        {
            string fileName = "programmer" + programmer.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(programmer.GetType());
            serializer.Serialize(fileStream, programmer);
        }

        public static void serialize(Project project)
        {
            string fileName = "project" + project.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(project.GetType());
            serializer.Serialize(fileStream, project);
        }

        public static void serialize(Finance finance)
        {
            string fileName = "finance" + finance.Id + ".xml";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(finance.GetType());
            serializer.Serialize(fileStream, finance);
        }
    }
}
