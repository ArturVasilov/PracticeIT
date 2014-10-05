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
    }
}
