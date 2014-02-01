using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UML
{
    public partial class MainForm : Form
    {
        private enum StatesOfClick
        {
            //here we can do clicks on the elements of control panel,
            //to add different types of elements, for first it's just class
            hothing,
            state_class,
        }

        private const String FIELDS = "Fields:";
        private const String METHODS = "Methods:";

        private List<Panel> classes_panels = new List<Panel>();

        private List<UserClass> classes = new List<UserClass>();
        private StatesOfClick state_of_click = StatesOfClick.hothing;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateCodeButton_Click(object sender, EventArgs e)
        {
            TestDatasClass td = new TestDatasClass();
            td.testMethod();
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            UserClass adding_class;

            ClassDialog class_dialog = new ClassDialog();
            if (class_dialog.ShowDialog() != DialogResult.OK)
                return;
            adding_class = new UserClass(class_dialog.ClassName, class_dialog.IsStatic,
                class_dialog.IsAbstract, class_dialog.AccessType);

            Panel newClass = new Panel();
            newClass.BorderStyle = BorderStyle.Fixed3D;
            newClass.BackColor = Color.Silver;

            Label newClassName = new Label();
            newClassName.Text = adding_class.Class_name;
            newClass.Controls.Add(newClassName);

            ElementsPanel.Controls.Add(newClass);
        }
    }
}
