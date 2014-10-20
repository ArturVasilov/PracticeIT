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
            createLargeCenterParagraph("Отчёт №" + report.Id, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("От кого: " + Company.Instance.getProgrammerById(report.AuthorId).Name, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Содержание отчета: " + report.Description, ref paragraph);

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
            Word.Application application = new Word.Application();
            Word.Document document = new Word.Document();

            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            createLargeCenterParagraph("Программист " + programmer.Name, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Умения: " + Company.Instance.getSkillsByIds(programmer.SkillsIds), ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Зарплата: " + programmer.Salary + " руб.", ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Дополнительно: " + programmer.Description, ref paragraph);

            try
            {
                document.SaveAs(path + "programmer" + programmer.Id);
            }
            catch (Exception)
            {
            }
            document = null;
            application = null;
            GC.Collect();
        }

        internal static void createWordDocument(Project project)
        {
            Word.Application application = new Word.Application();
            Word.Document document = new Word.Document();

            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            createLargeCenterParagraph("Проект от " + project.Customer, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Стоимость: " + project.Cost + " руб.", ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Дата сдачи: " + project.Date, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Исполнители: " + Company.Instance.getPerformersByIds(project.PerformersIds), ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Дополнительно: " + project.Description, ref paragraph);

            try
            {
                document.SaveAs(path + "project" + project.Id);
            }
            catch (Exception)
            {
            }
            document = null;
            application = null;
            GC.Collect();
        }

        internal static void createWordDocument(Finance finance)
        {
            Word.Application application = new Word.Application();
            Word.Document document = new Word.Document();

            Word.Paragraph paragraph = document.Content.Paragraphs.Add();
            createLargeCenterParagraph("Финансовый отчет №" + finance.Id, ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Доход: " + finance.Income + " руб.", ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Расход: " + finance.Expense + " руб.", ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Прибыль: " + finance.Profit + " руб.", ref paragraph);

            paragraph = document.Content.Paragraphs.Add();
            createUsualParagraph("Дополнительно: " + finance.Description, ref paragraph);

            try
            {
                document.SaveAs(path + "finance" + finance.Id);
            }
            catch (Exception)
            {
            }
            document = null;
            application = null;
            GC.Collect();
        }

        private static void createLargeCenterParagraph(string text, ref Word.Paragraph paragraph)
        {
            paragraph.Range.Text = text;
            paragraph.Range.Bold = 1;
            paragraph.Range.Font.Size = 18;
            paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            paragraph.Format.SpaceAfter = 20;
            paragraph.Range.InsertParagraphAfter();
        }

        private static void createUsualParagraph(string text, ref Word.Paragraph paragraph)
        {
            paragraph.Range.Text = text;
            paragraph.Range.Bold = 0;
            paragraph.Range.Font.Size = 14;
            paragraph.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            paragraph.Format.SpaceAfter = 20;
            paragraph.Range.InsertParagraphAfter();
        }

    }
}
