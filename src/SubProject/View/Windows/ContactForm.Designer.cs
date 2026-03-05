namespace SubProject.View.Windows
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            AddressBox = new TextBox();
            PhoneBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NameBox = new TextBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(12, 205);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(125, 27);
            AddressBox.TabIndex = 10;
            AddressBox.TextChanged += AddressBox_TextChanged;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(12, 117);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(125, 27);
            PhoneBox.TabIndex = 9;
            PhoneBox.TextChanged += PhoneBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 8;
            label2.Text = "Phone Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Full Name:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 33);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 6;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(232, 276);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 317);
            Controls.Add(CloseButton);
            Controls.Add(label3);
            Controls.Add(AddressBox);
            Controls.Add(PhoneBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Name = "ContactForm";
            Text = "ContactForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox AddressBox;
        private TextBox PhoneBox;
        private Label label2;
        private Label label1;
        private TextBox NameBox;
        private Button CloseButton;
    }
}