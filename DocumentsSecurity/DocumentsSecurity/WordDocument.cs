using System;
using System.IO;

using Word = Microsoft.Office.Interop.Word;

namespace DocumentsSecurity
{
    internal class WordDocument
    {
        private static string path = Path.GetDirectoryName(Path.GetDirectoryName(
            System.IO.Directory.GetCurrentDirectory())) + "\\bin\\Debug\\word\\";

        internal static void createWordDocument(Report report)
        {
            Word.Application application = new Word.Application();
            Word.Document document = new Word.Document();

            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            paragraph.Range.Text = "Отчёт №" + report.Id;
            paragraph.Range.Bold = 1;
            paragraph.Range.Font.Size = 18;
            paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            paragraph.Format.SpaceAfter = 20;
            paragraph.Range.InsertParagraphAfter();

            paragraph = document.Content.Paragraphs.Add();
            paragraph.Range.Text = "От кого: " + Company.Instance.getProgrammerById(report.AuthorId).Name;
            paragraph.Range.Bold = 0;
            paragraph.Range.Font.Size = 14;
            paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            paragraph.Format.SpaceAfter = 20;
            paragraph.Range.InsertParagraphAfter();

            paragraph = document.Content.Paragraphs.Add();
            paragraph.Range.Text = "Содержание отчета: " + report.Description;
            paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            paragraph.Range.Bold = 0;
            paragraph.Range.Font.Size = 14;
            paragraph.Format.SpaceAfter = 20;
            paragraph.Range.InsertParagraphAfter();

            try
            {
                document.SaveAs(path + "report" + report.Id);
            }
            catch (Exception)
            {
            }
            document = null;
            application = null;
            GC.Collect();
        }

        internal static void createWordDocument(Programmer programmer)
        {
        }

        internal static void createWordDocument(Project project)
        {
        }

        internal static void createWordDocument(Finance finance)
        {
        }

    }
}
