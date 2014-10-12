using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsSecurity
{
    public partial class DocumentsForm : Form
    {
        private Company company;

        public struct TableNameIdValueTriple
        {
            private int id;
            private string tableName;
            private string value;

            public string TableName { get { return tableName; } }
            public int Id { get { return id; } }
            public string Value { get { return value; } }

            public TableNameIdValueTriple(int id, string tableName, string value)
            {
                this.id = id;
                this.tableName = tableName;
                this.value = value;
            }
        }

        private List<TableNameIdValueTriple> documents;

        public DocumentsForm()
        {
            InitializeComponent();
            company = Company.Instance;
            documents = company.Database.AllDocuments;
            addAllDocumentsToListBox();
        }

        private void addAllDocumentsToListBox()
        {
            foreach (TableNameIdValueTriple triple in documents)
            {
                DocumentsListBox.Items.Add(triple.Value);
            }
        }

        private void AddReportButton_Click(object sender, EventArgs e)
        {
            AddReportDialog addReportDialog = new AddReportDialog();

            if (addReportDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                Report report = addReportDialog.getReport;
                DocumentsListBox.Items.Add(report.ToString());
                company.addReport(report);
                documents.Add(new TableNameIdValueTriple(report.Id,
                    DatabaseConstants.Finance.TABLE_NAME, report.ToString()));
            }
        }

        private void AddProgrammerDocumentButton_Click(object sender, EventArgs e)
        {
            AddProgrammerDialog addProgrammerDialog = new AddProgrammerDialog();

            if (addProgrammerDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                Programmer programmer = addProgrammerDialog.getProgrammer;
                DocumentsListBox.Items.Add(programmer.ToString());
                company.addProgrammer(programmer);
                documents.Add(new TableNameIdValueTriple(programmer.Id,
                    DatabaseConstants.Finance.TABLE_NAME, programmer.ToString()));
            }
        }

        private void AddProjectDocumentButton_Click(object sender, EventArgs e)
        {
            AddProjectDialog addProjectDialog = new AddProjectDialog();

            if (addProjectDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                Project project = addProjectDialog.getProject;
                DocumentsListBox.Items.Add(project.ToString());
                company.addProject(project); 
                documents.Add(new TableNameIdValueTriple(project.Id,
                     DatabaseConstants.Finance.TABLE_NAME, project.ToString()));
            }
        }

        private void AddFinanceDocumentButton_Click(object sender, EventArgs e)
        {
            AddFinanceDialog addFinanceDialog = new AddFinanceDialog();

            if (addFinanceDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                Finance finance = addFinanceDialog.getFinance;
                company.addFinance(finance); 
                DocumentsListBox.Items.Add(finance.ToString());
                documents.Add(new TableNameIdValueTriple(finance.Id,
                    DatabaseConstants.Finance.TABLE_NAME, finance.ToString()));
            }
        }

        private void ShowChosenDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            //TODO : open in Microsoft Word
        }

        private void EditChosenDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            TableNameIdValueTriple value = documents[index];
            switch (value.TableName)
            {
                case DatabaseConstants.Programmer.TABLE_NAME:
                    editProgrammerDocument(value.Id);
                    break;

                case DatabaseConstants.Project.TABLE_NAME:
                    editProjectDocument(value.Id);
                    break;

                case DatabaseConstants.Finance.TABLE_NAME:
                    editFinanceDocument(value.Id);
                    break;

                case DatabaseConstants.Report.TABLE_NAME:
                    editReportDocument(value.Id);
                    break;
            }
        }

        private void editProgrammerDocument(int id)
        {
            Programmer programmer = company.Database.getProgrammerById(id);
            AddProgrammerDialog addProgrammerDialog = new AddProgrammerDialog();
            string skills = company.Database.getSkillsByIds(programmer.SkillsIds);
            addProgrammerDialog.setFields(programmer.Name, programmer.Salary, skills, programmer.Description);
            if (addProgrammerDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.Database.editProgrammer(addProgrammerDialog.changeProgrammer(programmer.Id));
            }
        }

        private void editProjectDocument(int id)
        {
            Project project = company.Database.getProjectById(id);
            AddProjectDialog addProjectDialog = new AddProjectDialog();
            addProjectDialog.setFields(project.Customer, project.Cost, project.Date, 
                project.PerformersIds, project.Description);
            if (addProjectDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.Database.editProject(addProjectDialog.changeProject(project.Id));
            }
        }

        private void editFinanceDocument(int id)
        {
            Finance finance = company.Database.getFinanceById(id);
            AddFinanceDialog addFinanceDialog = new AddFinanceDialog();
            addFinanceDialog.setFields(finance.Income, finance.Expense, finance.Description);
            if (addFinanceDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.Database.editFinance(addFinanceDialog.changeFinance(finance.Id));
            }
        }

        private void editReportDocument(int id)
        {
            Finance finance = company.Database.getFinanceById(id);
            AddFinanceDialog addFinanceDialog = new AddFinanceDialog();
            addFinanceDialog.setFields(finance.Income, finance.Expense, finance.Description);
            if (addFinanceDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.Database.editFinance(addFinanceDialog.changeFinance(finance.Id));
            }
        }

        private void RemoveChosenDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0 || index >= documents.Count)
            {
                return;
            }
            company.Database.remove(documents[index].TableName, documents[index].Id);
            documents.RemoveAt(index);
            DocumentsListBox.Items.RemoveAt(index);
        }

        private void DocumentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            company.save();
        }
    }
}
