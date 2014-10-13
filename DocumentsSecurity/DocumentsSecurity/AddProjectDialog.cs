using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace DocumentsSecurity
{
    public partial class AddProjectDialog : Form
    {
        private Project project;

        private List<Programmer.NameIdPair> programmers;

        public AddProjectDialog()
        {
            InitializeComponent();
            programmers = Company.Instance.getAllProgrammers;
            foreach (Programmer.NameIdPair programmer in programmers)
            {
                DocumentProjectPerformersListBox.Items.Add(programmer.Name);
            }
        }

        public Project getProject
        {
            get { return project; }
        }

        private void DocumentProjectOKButton_Click(object sender, EventArgs e)
        {
            bool isAllOk = true;
            //id isn't important, it's generating at runtime
            int id = DatabaseConstants.IdsKeeper.PROJECT_ID;

            string customer = DocumentProjectCustomerTextBox.Text;
            customer = customer == null ? "" : customer;

            long cost = -1;
            #region getting cost
            try
            {
                cost = long.Parse(DocumentProjectCostTextBox.Text);
                DocumentProjectCostTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DocumentProjectCostTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            catch (Exception)
            {
                DocumentProjectCostTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            #endregion

            string date = DocumentProjectDateTextBox.Text;
            Regex dateRegex = new Regex("[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (!dateRegex.IsMatch(date))
            {
                DocumentProjectDateTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            else
            {
                DocumentProjectDateTextBox.BackColor = Color.White;
            }

            if (!isAllOk)
            {
                return;
            }

            List<int> selectedIndices = new List<int>();
            foreach (int index in DocumentProjectPerformersListBox.SelectedIndices)
            {
                selectedIndices.Add(index);
            }
            if (selectedIndices.Count == 0) 
            {
                DocumentProjectPerformersListBox.BackColor = Color.Red;
                return;
            }
            int[] performersIds = new int[selectedIndices.Count];
            for (int i = 0; i < selectedIndices.Count; i++)
            {
                performersIds[i] = programmers[selectedIndices[i]].Id;
            }
            
            string description = DocumentProjectDescriptionTextBox.Text;
            description = description == null ? "" : description;

            project = new Project(id, description, customer, cost, date, performersIds);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        internal void setFields(string customer, long cost, string date, List<int> ids, string description)
        {
            DocumentProjectCustomerTextBox.Text = customer;
            DocumentProjectCostTextBox.Text = cost.ToString();
            DocumentProjectDateTextBox.Text = date;
            DocumentProjectDescriptionTextBox.Text = description;
            for (int i = 0; i < programmers.Count; i++)
            {
                if (ids.Contains(programmers[i].Id))
                {
                    DocumentProjectPerformersListBox.SelectedIndices.Add(i);
                }
            }
        }

        internal Project changeProject(int id)
        {
            project.Id = id;
            return project;
        }
    }
}
