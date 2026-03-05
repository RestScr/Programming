namespace NoteListApp
{
    partial class NoteListAppMainForm
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
            noteListControl = new Controls.NoteListControl();
            SuspendLayout();
            // 
            // noteListControl
            // 
            noteListControl.Dock = DockStyle.Fill;
            noteListControl.Location = new Point(0, 0);
            noteListControl.Name = "noteListControl";
            noteListControl.Size = new Size(843, 525);
            noteListControl.TabIndex = 0;
            // 
            // NoteListAppMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 525);
            Controls.Add(noteListControl);
            Name = "NoteListAppMainForm";
            Text = "NoteListApp";
            FormClosing += NoteListAppMainForm_FormClosing;
            Load += NoteListAppMainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.NoteListControl noteListControl;
    }
}
