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

        public DocumentsForm()
        {
            InitializeComponent();
            company = Company.Instance;
        }

        private void AddDocumentButton_Click(object sender, EventArgs e)
        {
            AddDocumentDialog addDocumentDialog = new AddDocumentDialog();

            if (addDocumentDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                //TODO : catch exception and restart dialog
                Document document = addDocumentDialog.getDocument;
                company.addDocument(document);
                //add document to form list
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
                //TODO : catch exception and restart dialog
                Programmer programmer = addProgrammerDialog.getProgrammer;
                company.addProgrammer(programmer);
                //add document to form list
            }
        }
    }
}
