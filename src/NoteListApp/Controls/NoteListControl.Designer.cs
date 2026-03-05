namespace NoteListApp.Controls
{
    partial class NoteListControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            NotesListBox = new ListBox();
            CreateNoteButton = new PictureBox();
            EditNoteButton = new PictureBox();
            RemoveNoteButton = new PictureBox();
            SelectedNoteGroup = new GroupBox();
            CategoryComboBox = new ComboBox();
            CreationTextBox = new TextBox();
            TitleTextBox = new TextBox();
            NoteTextBox = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CreateNoteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditNoteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveNoteButton).BeginInit();
            SelectedNoteGroup.SuspendLayout();
            SuspendLayout();
            // 
            // NotesListBox
            // 
            NotesListBox.FormattingEnabled = true;
            NotesListBox.Location = new Point(14, 16);
            NotesListBox.Name = "NotesListBox";
            NotesListBox.Size = new Size(240, 424);
            NotesListBox.TabIndex = 0;
            NotesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // CreateNoteButton
            // 
            CreateNoteButton.Image = Properties.Resources.add;
            CreateNoteButton.Location = new Point(14, 446);
            CreateNoteButton.Name = "CreateNoteButton";
            CreateNoteButton.Size = new Size(51, 35);
            CreateNoteButton.TabIndex = 1;
            CreateNoteButton.TabStop = false;
            CreateNoteButton.Click += CreateNoteButton_Click;
            // 
            // EditNoteButton
            // 
            EditNoteButton.Image = Properties.Resources.edit;
            EditNoteButton.Location = new Point(71, 446);
            EditNoteButton.Name = "EditNoteButton";
            EditNoteButton.Size = new Size(54, 35);
            EditNoteButton.TabIndex = 2;
            EditNoteButton.TabStop = false;
            EditNoteButton.Click += EditNoteButton_Click;
            // 
            // RemoveNoteButton
            // 
            RemoveNoteButton.Image = Properties.Resources.remove;
            RemoveNoteButton.Location = new Point(131, 446);
            RemoveNoteButton.Name = "RemoveNoteButton";
            RemoveNoteButton.Size = new Size(54, 35);
            RemoveNoteButton.TabIndex = 3;
            RemoveNoteButton.TabStop = false;
            RemoveNoteButton.Click += RemoveNoteButton_Click;
            // 
            // SelectedNoteGroup
            // 
            SelectedNoteGroup.Controls.Add(CategoryComboBox);
            SelectedNoteGroup.Controls.Add(CreationTextBox);
            SelectedNoteGroup.Controls.Add(TitleTextBox);
            SelectedNoteGroup.Controls.Add(NoteTextBox);
            SelectedNoteGroup.Controls.Add(label4);
            SelectedNoteGroup.Controls.Add(label3);
            SelectedNoteGroup.Controls.Add(label2);
            SelectedNoteGroup.Controls.Add(label1);
            SelectedNoteGroup.Location = new Point(275, 16);
            SelectedNoteGroup.Name = "SelectedNoteGroup";
            SelectedNoteGroup.Size = new Size(516, 323);
            SelectedNoteGroup.TabIndex = 4;
            SelectedNoteGroup.TabStop = false;
            SelectedNoteGroup.Text = "Selected Note";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Enabled = false;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Дом", "Работа", "Спорт", "Финансы" });
            CategoryComboBox.Location = new Point(96, 237);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 7;
            // 
            // CreationTextBox
            // 
            CreationTextBox.Location = new Point(96, 204);
            CreationTextBox.Name = "CreationTextBox";
            CreationTextBox.ReadOnly = true;
            CreationTextBox.Size = new Size(151, 27);
            CreationTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Location = new Point(96, 36);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(365, 27);
            TitleTextBox.TabIndex = 5;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Enabled = false;
            NoteTextBox.Location = new Point(96, 69);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(365, 123);
            NoteTextBox.TabIndex = 4;
            NoteTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 236);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 207);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Created:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Text:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // NoteListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedNoteGroup);
            Controls.Add(RemoveNoteButton);
            Controls.Add(EditNoteButton);
            Controls.Add(CreateNoteButton);
            Controls.Add(NotesListBox);
            Name = "NoteListControl";
            Size = new Size(818, 497);
            ((System.ComponentModel.ISupportInitialize)CreateNoteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditNoteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveNoteButton).EndInit();
            SelectedNoteGroup.ResumeLayout(false);
            SelectedNoteGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox NotesListBox;
        private PictureBox CreateNoteButton;
        private PictureBox EditNoteButton;
        private PictureBox RemoveNoteButton;
        private GroupBox SelectedNoteGroup;
        private RichTextBox NoteTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CategoryComboBox;
        private TextBox CreationTextBox;
        private TextBox TitleTextBox;
    }
}
