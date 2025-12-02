namespace ObjectOrientedPractics.View.Windows
{
    partial class DiscountAdder
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
            label1 = new Label();
            label2 = new Label();
            DiscountCategoryComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Percent Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // DiscountCategoryComboBox
            // 
            DiscountCategoryComboBox.FormattingEnabled = true;
            DiscountCategoryComboBox.Location = new Point(90, 48);
            DiscountCategoryComboBox.Name = "DiscountCategoryComboBox";
            DiscountCategoryComboBox.Size = new Size(206, 28);
            DiscountCategoryComboBox.TabIndex = 2;
            DiscountCategoryComboBox.Text = "Выберите категорию...";
            DiscountCategoryComboBox.SelectedIndexChanged += DiscountCategoryComboBox_SelectedIndexChanged;
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(103, 97);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(93, 46);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(202, 97);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 48);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // DiscountAdder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 155);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(DiscountCategoryComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DiscountAdder";
            Text = "DiscountAdder";
            Load += DiscountAdder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox DiscountCategoryComboBox;
        private Button OkButton;
        private Button CancelButton;
    }
}