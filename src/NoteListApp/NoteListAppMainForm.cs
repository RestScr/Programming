using System.Diagnostics;
using NoteListApp.Controls;
using NoteListApp.Model.Classes;

namespace NoteListApp
{
    public partial class NoteListAppMainForm : Form
    {
        public NoteListAppMainForm()
        {
            InitializeComponent();
        }

        private void NoteListAppMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            noteListControl.SaveDataToFile();
        }

        private void NoteListAppMainForm_Load(object sender, EventArgs e)
        {
            noteListControl.LoadDataFromFile();
        }
    }
}
