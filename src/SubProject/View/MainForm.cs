using System.Diagnostics;
using SubProject.Model;
using SubProject.View.Windows;

namespace SubProject
{
    public partial class MainForm : Form
    {

        private List<ContactForm> _contactForms { get; } = new List<ContactForm>();

        private const int _formsCount = 10;

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < _formsCount; i++)
            {
                _contactForms.Add(new ContactForm());
            }

            for (int i = 0; i < _formsCount; i++)
            {
                for (int j = 0; j < _formsCount; j++)
                {
                    if (!_contactForms[i].Equals(_contactForms[j]))
                    {
                        _contactForms[i].FieldChanged += _contactForms[j].FillFields;
                    }
                }
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _formsCount; i++)
            {
                _contactForms[i].Show();
            }
        }

    }
}
