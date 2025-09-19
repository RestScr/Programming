using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс пользовательского элемента управления, отвечающего за времена года.
    /// </summary>
    public partial class SeasonsHandleGroup : UserControl
    {
        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public SeasonsHandleGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// События при выборе лета.
        /// </summary>
        private void Summer()
        {
            this.BackColor = Model.Static.AppColors.SummerColor;
            MessageBox.Show("УРАААААА СОЛНЦЕ!!!", "Ура Солнце!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// События при выборе осени.
        /// </summary>
        private void Autumn()
        {
            this.BackColor = Model.Static.AppColors.AutumnColor;
            MessageBox.Show("осень....", "а где солнце????", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// События при выборе зимы.
        /// </summary>
        private void Winter()
        {
            this.BackColor = Model.Static.AppColors.WinterColor;

            System.Drawing.Drawing2D.GraphicsPath window = new System.Drawing.Drawing2D.GraphicsPath();
            window.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(window);

            MessageBox.Show("бррр, холодно", "брррр!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// События при выборе весны.
        /// </summary>
        private void Spring()
        {
            this.BackColor = Model.Static.AppColors.SpringColor;
            MessageBox.Show("снег тает", "как прекрасна весна!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Кнопка, отвечающая за выполнение событий в зависимости от
        /// выбранного сезона.
        /// </summary>
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
