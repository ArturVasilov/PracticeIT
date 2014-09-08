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
    public partial class AddProgrammerDialog : Form
    {
        private Programmer programmer;

        public AddProgrammerDialog()
        {
            InitializeComponent();
        }

        public Programmer getProgrammer
        {
            get
            {
                return programmer;
            }
        }

        private void DocumentProgrammerOKButton_Click_1(object sender, EventArgs e)
        {
            bool isAllOk = true;
            long id = -1;
            #region getting id
            try
            {
                id = long.Parse(DocumentProgrammerIdTextBox.Text);
                DocumentProgrammerIdTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DocumentProgrammerIdTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            catch (Exception)
            {
                DocumentProgrammerIdTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            if (Company.Instance.containsId(id))
            {
                DocumentProgrammerIdTextBox.BackColor = Color.Red;
                MessageBox.Show("This id is already exist!");
                return;
            }
            #endregion

            string name = DocumentProgrammerNameTextBox.Text;
            name = name == null ? "" : name;

            int salary = -1;
            #region getting salary
            try
            {
                salary = Int32.Parse(DocumentProgrammerSalaryTextBox.Text);
                DocumentProgrammerSalaryTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DocumentProgrammerSalaryTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            catch (Exception)
            {
                DocumentProgrammerSalaryTextBox.BackColor = Color.Red;
                isAllOk = false;
            }
            #endregion

            if (!isAllOk)
            {
                return;
            }

            string skill = DocumentProgrammerSkillsTextBox.Text;
            string[] skills = skill.Split(',');
            for (int i = 0; i < skills.Length; i++)
            {
                //Not so good, but enough
                while (skills[i].StartsWith(" "))
                {
                    skills[i] = skills[i].Remove(0, 1);
                }
            }

            string description = DocumentProgrammerDescriptionTextBox.Text;
            description = description == null ? "" : description;

            programmer = new Programmer(id, description, name, salary, skills);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
