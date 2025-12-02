namespace TravelAgency
{
    partial class AddTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTour));
            pictureBox1 = new PictureBox();
            cityComboBox = new ComboBox();
            cityLabel = new Label();
            startDateLabel = new Label();
            startDateTextBox = new TextBox();
            endDateLabel = new Label();
            endDateTextBox = new TextBox();
            transportPriceTextBox = new TextBox();
            transportPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 510);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(39, 516);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(151, 28);
            cityComboBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(54, 477);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(64, 596);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(76, 20);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "Start Date";
            // 
            // startDateTextBox
            // 
            startDateTextBox.Location = new Point(54, 631);
            startDateTextBox.Name = "startDateTextBox";
            startDateTextBox.Size = new Size(125, 27);
            startDateTextBox.TabIndex = 4;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(215, 596);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(70, 20);
            endDateLabel.TabIndex = 5;
            endDateLabel.Text = "End Date";
            // 
            // endDateTextBox
            // 
            endDateTextBox.Location = new Point(206, 631);
            endDateTextBox.Name = "endDateTextBox";
            endDateTextBox.Size = new Size(125, 27);
            endDateTextBox.TabIndex = 6;
            // 
            // transportPriceTextBox
            // 
            transportPriceTextBox.Location = new Point(255, 702);
            transportPriceTextBox.Name = "transportPriceTextBox";
            transportPriceTextBox.Size = new Size(125, 27);
            transportPriceTextBox.TabIndex = 8;
            // 
            // transportPriceLabel
            // 
            transportPriceLabel.AutoSize = true;
            transportPriceLabel.Location = new Point(281, 679);
            transportPriceLabel.Name = "transportPriceLabel";
            transportPriceLabel.Size = new Size(107, 20);
            transportPriceLabel.TabIndex = 7;
            transportPriceLabel.Text = "Transport Price";
            // 
            // AddTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 877);
            Controls.Add(transportPriceTextBox);
            Controls.Add(transportPriceLabel);
            Controls.Add(endDateTextBox);
            Controls.Add(endDateLabel);
            Controls.Add(startDateTextBox);
            Controls.Add(startDateLabel);
            Controls.Add(cityLabel);
            Controls.Add(cityComboBox);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Agency";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cityComboBox;
        private Label cityLabel;
        private Label startDateLabel;
        private TextBox startDateTextBox;
        private Label endDateLabel;
        private TextBox endDateTextBox;
        private TextBox transportPriceTextBox;
        private Label transportPriceLabel;
    }
}