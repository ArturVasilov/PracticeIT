using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML
{
    public partial class ClassDialog : Form
    {
        public ClassDialog()
        {
            InitializeComponent();

            ClassDialogStaticCB.SelectedIndex = 1;
            ClassDialogAbstractCB.SelectedIndex = 1;
            ClassDialogAccessCB.SelectedIndex = 0;
        }

        public String ClassName
        {
            get { return ClassDialogNameTB.Text; }
            set { ClassDialogNameTB.Text = value; }
        }

        public bool IsAbstract
        {
            get { return ClassDialogAbstractCB.Text == "true"; }
        }

        public bool IsStatic
        {
            get { return ClassDialogStaticCB.Text == "true"; }
        }

        public AccessTypesC.AccessTypes AccessType
        {
            get { return AccessTypesC.valueOfString(ClassDialogAccessCB.Text); }
        }

    }
}
