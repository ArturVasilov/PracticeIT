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
        public AddProgrammerDialog()
        {
            InitializeComponent();
        }

        public Programmer getProgrammer
        {
            get
            {
                long id = -1;
                #region getting id
                try
                {
                    id = long.Parse(ProgrammertDocumentIdTextBox.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("trying parse programmers id has failed:(");
                }
                catch (Exception)
                {
                    throw new Exception("something strange has happened trying parse salary id");
                }
                #endregion

                string name = DocumentProgrammerNameTextBox.Text;
                name = name == null ? "" : name;

                int salary = -1;
                #region getting salary
                try
                {
                    salary = Int32.Parse(DocumentProgrammerSalaryTextBox.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("trying parse programmers salary has failed:(");
                }
                catch (Exception)
                {
                    throw new Exception("something strange has happened trying parse programmers salary");
                }
                #endregion

                string skill = DocumentProgrammerSkillsTextBox.Text;
                //TODO : remove unused spaces
                string[] skills = skill.Split(',');

                string description = DocumentProgrammerDescriptionTextBox.Text;
                description = description == null ? "" : description;

                return new Programmer(id, description, name, salary, skills);
            }
        }
    }
}
