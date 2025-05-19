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
            noteListControl1 = new Controls.NoteListControl();
            SuspendLayout();
            // 
            // noteListControl1
            // 
            noteListControl1.Dock = DockStyle.Fill;
            noteListControl1.Location = new Point(0, 0);
            noteListControl1.Name = "noteListControl1";
            noteListControl1.Size = new Size(843, 525);
            noteListControl1.TabIndex = 0;
            noteListControl1.Load += noteListControl1_Load;
            // 
            // NoteListAppMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 525);
            Controls.Add(noteListControl1);
            Name = "NoteListAppMainForm";
            Text = "NoteListApp";
            ResumeLayout(false);
        }

        #endregion

        private Controls.NoteListControl noteListControl1;
    }
}
