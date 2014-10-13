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
    public partial class AddReportDialog : Form
    {
        private Report report;

        private List<Programmer.NameIdPair> programmers;

        public AddReportDialog()
        {
            InitializeComponent();
            programmers = Company.Instance.getAllProgrammers;
            foreach (Programmer.NameIdPair programmer in programmers)
            {
                DocumentReportAuthorComboBox.Items.Add(programmer.Name);
            }
        }

        public Report getReport
        {
            get
            {
                return report;
            }
        }

        private void DocumentReportOKButton_Click(object sender, EventArgs e)
        {
            int index = DocumentReportAuthorComboBox.SelectedIndex;
            if (index < 0)
            {
                DocumentReportAuthorComboBox.BackColor = Color.Red;
                return;
            }
            int id = DatabaseConstants.IdsKeeper.REPORT_ID;
            int programmerId = programmers[index].Id;
            string content = DocumentReportContentTextBox.Text;
            report = new Report(id, programmerId, content);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        internal void setFields(int authorId, string content)
        {
            for (int i = 0; i < programmers.Count; i++)
            {
                if (authorId == programmers[i].Id)
                {
                    DocumentReportAuthorComboBox.SelectedItem = i;
                    DocumentReportAuthorComboBox.Text = programmers[i].Name;
                    break;
                }
            }
            DocumentReportContentTextBox.Text = content;
        }

        internal Report changeReport(int id)
        {
            report.Id = id;
            return report;
        }
    }
}
