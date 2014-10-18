using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace DocumentsSecurity
{
    public partial class DocumentsForm : Form
    {
        private Company company;

        private List<TableNameIdValueTriple> documents;

        public DocumentsForm()
        {
            InitializeComponent();
            company = Company.Instance;
            documents = company.AllDocuments;
            addAllDocumentsToListBox();
            try
            {
                company.verifyDocuments();
            }
            catch (VerificationException ve)
            {
                MessageBox.Show(ve.Message + " Unverified documents:" + ve.unverifiedDocuments);
            }
        }

        private void addAllDocumentsToListBox()
        {
            foreach (TableNameIdValueTriple triple in documents)
            {
                DocumentsListBox.Items.Add(triple.Value);
            }
        }

        #region add functions
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
                    DatabaseConstants.Report.TABLE_NAME, report.ToString()));
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
                    DatabaseConstants.Programmer.TABLE_NAME, programmer.ToString()));
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
                     DatabaseConstants.Project.TABLE_NAME, project.ToString()));
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
        #endregion

        #region edit functions
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
            Programmer programmer = company.getProgrammerById(id);
            AddProgrammerDialog addProgrammerDialog = new AddProgrammerDialog();
            string skills = company.getSkillsByIds(programmer.SkillsIds);
            addProgrammerDialog.setFields(programmer.Name, programmer.Salary, skills, programmer.Description);
            if (addProgrammerDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.editProgrammer(addProgrammerDialog.changeProgrammer(programmer.Id));
            }
        }

        private void editProjectDocument(int id)
        {
            Project project = company.getProjectById(id);
            AddProjectDialog addProjectDialog = new AddProjectDialog();
            addProjectDialog.setFields(project.Customer, project.Cost, project.Date, 
                project.PerformersIds, project.Description);
            if (addProjectDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.editProject(addProjectDialog.changeProject(project.Id));
            }
        }

        private void editFinanceDocument(int id)
        {
            Finance finance = company.getFinanceById(id);
            AddFinanceDialog addFinanceDialog = new AddFinanceDialog();
            addFinanceDialog.setFields(finance.Income, finance.Expense, finance.Description);
            if (addFinanceDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.editFinance(addFinanceDialog.changeFinance(finance.Id));
            }
        }

        private void editReportDocument(int id)
        {
            Report report = company.getReportById(id);
            AddReportDialog addReportDialog = new AddReportDialog();
            addReportDialog.setFields(report.AuthorId, report.Description);
            if (addReportDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                company.editReport(addReportDialog.changeReport(report.Id));
            }
        }
        #endregion

        private void RemoveChosenDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0 || index >= documents.Count)
            {
                return;
            }
            company.remove(documents[index].TableName, documents[index].Id);
            documents.RemoveAt(index);
            DocumentsListBox.Items.RemoveAt(index);
        }

        private void ShowChosenDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            TableNameIdValueTriple value = documents[index];
            company.createWordDocument(value.TableName, value.Id);
        }

        private void serializeDocumentButton_Click(object sender, EventArgs e)
        {
            int index = DocumentsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            TableNameIdValueTriple value = documents[index];
            company.serialize(value.TableName, value.Id);
            MessageBox.Show("Документ сериализован!");
        }   

        private void DocumentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            company.save();
        }

    }
}
