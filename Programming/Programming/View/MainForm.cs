using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        // Статический массив, содержащий типы перечислений
        private static System.Type[] EnumTypes = {
            typeof(Model.Color),
            typeof(Model.EducationForm),
            typeof(Model.Genre),
            typeof(Model.Season),
            typeof(Model.SmartphoneManufacturers),
            typeof(Model.Weekday)
        };

        public MainForm()
        {
            InitializeComponent();
        }

        // <summary>
        // Загрузка формы
        // </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // <summary>
        // Добавление новых элементов в ListBox
        // с удалением предыдущих
        // </summary>
        // <param name="listBox"> Данный листбокс </param>
        // <param name="itemNames"> Список имен элементов </param>
        static private void SetItemsToListBox(ListBox listBox, string[] itemNames)
        {
            listBox.Items.Clear();
            foreach (string name in itemNames)
            {
                listBox.Items.Add(name);
            }
        }

        // <summary>
        // События, происходящие при выборе
        // элемента в листбоксе перечислений
        // </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            SetItemsToListBox(ValuesListBox, Enum.GetNames(EnumTypes[selectedIndex]));
        }

        // <summary>
        // Действия, происходящие при выборе
        // элемента в листбоксе значений
        // </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEnum = EnumsListBox.SelectedIndex;
            string selectedValue = ValuesListBox.SelectedItem.ToString();
            ValueTextBox.Text = Convert.ToString((int)Enum.Parse(EnumTypes[selectedEnum], selectedValue));
        }

        // <summary>
        // Поведение кнопки парсинга перечисления дня недели
        // </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string enteredValue = ParseTextBox.Text;
            try
            {
                object foundValue = Enum.Parse(typeof(Weekday), enteredValue);
                ParseOutputLabel.Text = $"Это день недели ({enteredValue} = {(int)foundValue})";
            }
            catch (System.ArgumentException)
            {
                ParseOutputLabel.Text = "Нет такого дня недели";
            }
        }

        // <summary>
        // События при выборе лета
        // </summary>
        private void Summer()
        {
            MessageBox.Show("УРАААААА СОЛНЦЕ!!!", "Ура Солнце!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // <summary>
        // События при выборе осени
        // </summary>
        private void Autumn()
        {
            this.BackColor = System.Drawing.Color.DarkOrange;
        }

        // <summary>
        // События при выборе зимы
        // </summary>
        private void Winter()
        {
            this.BackColor = System.Drawing.Color.DarkGray;

            System.Drawing.Drawing2D.GraphicsPath window = new System.Drawing.Drawing2D.GraphicsPath();
            window.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(window);

            MessageBox.Show("бррр, холодно", "брррр!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // <summary>
        // События при выборе весны
        // </summary>
        private void Spring()
        {
            this.BackColor = System.Drawing.Color.LightGreen;
        }


        // <summary>
        // Кнопка, отвечающая за выполнение событий в зависимости от
        // выбранного сезона
        // </summary>
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    Summer();
                    break;
                case 1:
                    Autumn();
                    break;
                case 2:
                    Winter();
                    break;
                case 3:
                    Spring();
                    break;
            }
        }
    }
}
