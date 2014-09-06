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
        public AddDocumentDialog()
        {
            InitializeComponent();
        }

        public Document getDocument
        {
            get
            {
                long id = -1;
                try 
                {
                    id = long.Parse(IdTextBox.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("trying parse documents id has failed:(");
                }
                catch (Exception)
                {
                    throw new Exception("something strange has happened trying parse documents id");
                }
                string text = DescriptionTextBox.Text;
                text = text == null ? "" : text;
                return new Document(id, Document.DocumentType.None, text);
            }
        }
    }
}
