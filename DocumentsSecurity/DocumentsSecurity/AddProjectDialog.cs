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

        public AddProjectDialog()
        {
            InitializeComponent();
        }

        public Project getProject
        {
            get { return project; }
        }

        private void DocumentProjectOKButton_Click(object sender, EventArgs e)
        {
            bool isAllOk = true;
            //id isn't important, it's generating at runtime
            long id = 0;

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

            string[] performers = DocumentProjectPerformersTextBox.Text.Split(',');
            for (int i = 0; i < performers.Length; i++)
            {
                while (performers[i].StartsWith(" "))
                {
                    performers[i] = performers[i].Remove(0, 1);
                }
            }

            string description = DocumentProjectDescriptionTextBox.Text;
            description = description == null ? "" : description;

            project = new Project(id, description, customer, cost, date, performers);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
