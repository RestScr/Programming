namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IndexBox = new TextBox();
            CountryBox = new TextBox();
            CityBox = new TextBox();
            StreetBox = new TextBox();
            BuildingBox = new TextBox();
            ApartmentBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 71);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 71);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 111);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 3;
            label5.Text = "Street:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 152);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 4;
            label6.Text = "Building:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 152);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 5;
            label7.Text = "Apartment:";
            // 
            // IndexBox
            // 
            IndexBox.Location = new Point(88, 32);
            IndexBox.Name = "IndexBox";
            IndexBox.Size = new Size(125, 27);
            IndexBox.TabIndex = 6;
            IndexBox.TextChanged += IndexBox_TextChanged;
            // 
            // CountryBox
            // 
            CountryBox.Location = new Point(88, 71);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new Size(228, 27);
            CountryBox.TabIndex = 7;
            CountryBox.TextChanged += CountryBox_TextChanged;
            // 
            // CityBox
            // 
            CityBox.Location = new Point(376, 71);
            CityBox.Name = "CityBox";
            CityBox.Size = new Size(205, 27);
            CityBox.TabIndex = 8;
            CityBox.TextChanged += CityBox_TextChanged;
            // 
            // StreetBox
            // 
            StreetBox.Location = new Point(88, 111);
            StreetBox.Name = "StreetBox";
            StreetBox.Size = new Size(493, 27);
            StreetBox.TabIndex = 9;
            StreetBox.TextChanged += StreetBox_TextChanged;
            // 
            // BuildingBox
            // 
            BuildingBox.Location = new Point(88, 152);
            BuildingBox.Name = "BuildingBox";
            BuildingBox.Size = new Size(125, 27);
            BuildingBox.TabIndex = 10;
            BuildingBox.TextChanged += BuildingBox_TextChanged;
            // 
            // ApartmentBox
            // 
            ApartmentBox.Location = new Point(342, 152);
            ApartmentBox.Name = "ApartmentBox";
            ApartmentBox.Size = new Size(144, 27);
            ApartmentBox.TabIndex = 11;
            ApartmentBox.TextChanged += ApartmentBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(ApartmentBox);
            Controls.Add(BuildingBox);
            Controls.Add(StreetBox);
            Controls.Add(CityBox);
            Controls.Add(CountryBox);
            Controls.Add(IndexBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(613, 194);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IndexBox;
        private TextBox CountryBox;
        private TextBox CityBox;
        private TextBox StreetBox;
        private TextBox BuildingBox;
        private TextBox ApartmentBox;
    }
}
