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
    public partial class AddDocumentDialog : Form
    {
        private Document document;

        public AddDocumentDialog()
        {
            InitializeComponent();
        }

        public Document getDocument
        {
            get
            {
                return document;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            long id = -1;
            try
            {
                id = long.Parse(IdTextBox.Text);
            }
            catch (FormatException)
            {
                IdTextBox.BackColor = Color.Red;
                return;
            }
            catch (Exception)
            {
                IdTextBox.BackColor = Color.Red;
                return;
            }
            if (Company.Instance.containsId(id))
            {
                IdTextBox.BackColor = Color.Red;
                MessageBox.Show("This id is already exist!");
                return;
            }

            string text = DescriptionTextBox.Text;
            text = text == null ? "" : text;

            document = new Document(id, text);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
