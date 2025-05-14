namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            weekdayParsingGroupControl1 = new View.Panels.WeekdayParsingGroupControl();
            enumerationsGroupControl1 = new View.Panels.EnumerationsGroupControl();
            seasonsHandleGroup1 = new View.Panels.SeasonsHandleGroup();
            ClassesPage = new TabPage();
            moviesGroupControl1 = new View.Panels.MoviesGroupControl();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            ClassesPage.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Controls.Add(Rectangles);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(827, 503);
            MainTabControl.TabIndex = 1;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(weekdayParsingGroupControl1);
            EnumsPage.Controls.Add(enumerationsGroupControl1);
            EnumsPage.Controls.Add(seasonsHandleGroup1);
            EnumsPage.Location = new Point(4, 29);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(819, 470);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingGroupControl1
            // 
            weekdayParsingGroupControl1.Location = new Point(1, 319);
            weekdayParsingGroupControl1.Name = "weekdayParsingGroupControl1";
            weekdayParsingGroupControl1.Size = new Size(433, 143);
            weekdayParsingGroupControl1.TabIndex = 4;
            // 
            // enumerationsGroupControl1
            // 
            enumerationsGroupControl1.Location = new Point(1, 0);
            enumerationsGroupControl1.Name = "enumerationsGroupControl1";
            enumerationsGroupControl1.Size = new Size(815, 318);
            enumerationsGroupControl1.TabIndex = 3;
            // 
            // seasonsHandleGroup1
            // 
            seasonsHandleGroup1.Location = new Point(427, 319);
            seasonsHandleGroup1.Name = "seasonsHandleGroup1";
            seasonsHandleGroup1.Size = new Size(384, 143);
            seasonsHandleGroup1.TabIndex = 2;
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(moviesGroupControl1);
            ClassesPage.Controls.Add(rectanglesControl1);
            ClassesPage.Location = new Point(4, 29);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Size = new Size(819, 470);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // moviesGroupControl1
            // 
            moviesGroupControl1.Location = new Point(392, 14);
            moviesGroupControl1.Name = "moviesGroupControl1";
            moviesGroupControl1.Size = new Size(409, 293);
            moviesGroupControl1.TabIndex = 10;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(8, 14);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(388, 453);
            rectanglesControl1.TabIndex = 9;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(819, 470);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.AutoSize = true;
            rectanglesCollisionControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(813, 464);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 503);
            Controls.Add(MainTabControl);
            MinimumSize = new Size(845, 550);
            Name = "MainForm";
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            ClassesPage.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        private void DecreaseRectanglesButton_MouseHover1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage ClassesPage;
        private TabPage Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.SeasonsHandleGroup seasonsHandleGroup1;
        private View.Panels.EnumerationsGroupControl enumerationsGroupControl1;
        private View.Panels.WeekdayParsingGroupControl weekdayParsingGroupControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.MoviesGroupControl moviesGroupControl1;
    }
}
