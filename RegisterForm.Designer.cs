namespace TravelAgency
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            RegisterPictureBox = new PictureBox();
            PersonalInfoLabel = new Label();
            firstNameTextBox = new TextBox();
            secondNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            egnLabel = new Label();
            egnTextBox = new TextBox();
            maleRadioBtn = new RadioButton();
            femaleRadioBtn = new RadioButton();
            groupBox1 = new GroupBox();
            insuranceNumberTextBox = new TextBox();
            addBtn = new Button();
            backBtn = new Button();
            insuranceNumberLabel = new Label();
            CountryLabel = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            BirthdateCalendar = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)RegisterPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterPictureBox
            // 
            RegisterPictureBox.Image = Properties.Resources.RegisterFormImage1;
            RegisterPictureBox.Location = new Point(-1, -1);
            RegisterPictureBox.Name = "RegisterPictureBox";
            RegisterPictureBox.Size = new Size(700, 510);
            RegisterPictureBox.TabIndex = 0;
            RegisterPictureBox.TabStop = false;
            // 
            // PersonalInfoLabel
            // 
            PersonalInfoLabel.AutoSize = true;
            PersonalInfoLabel.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonalInfoLabel.ForeColor = Color.MidnightBlue;
            PersonalInfoLabel.Location = new Point(29, 405);
            PersonalInfoLabel.Name = "PersonalInfoLabel";
            PersonalInfoLabel.Size = new Size(230, 22);
            PersonalInfoLabel.TabIndex = 1;
            PersonalInfoLabel.Text = "Personal Contact Info";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.WhiteSmoke;
            firstNameTextBox.Cursor = Cursors.Hand;
            firstNameTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.ForeColor = Color.Gray;
            firstNameTextBox.Location = new Point(19, 454);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(197, 26);
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.Text = "First Name";
            firstNameTextBox.Enter += firstNameTextBox_Enter;
            firstNameTextBox.Leave += firstNameTextBox_Leave;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.BackColor = Color.WhiteSmoke;
            secondNameTextBox.Cursor = Cursors.Hand;
            secondNameTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNameTextBox.ForeColor = Color.Gray;
            secondNameTextBox.Location = new Point(249, 454);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.Size = new Size(197, 26);
            secondNameTextBox.TabIndex = 3;
            secondNameTextBox.Text = "Second Name";
            secondNameTextBox.Enter += secondNameTextBox_Enter;
            secondNameTextBox.Leave += secondNameTextBox_Leave;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.WhiteSmoke;
            lastNameTextBox.Cursor = Cursors.Hand;
            lastNameTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.ForeColor = Color.Gray;
            lastNameTextBox.Location = new Point(480, 454);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(197, 26);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.Text = "Last Name";
            lastNameTextBox.Enter += lastNameTextBox_Enter;
            lastNameTextBox.Leave += lastNameTextBox_Leave;
            // 
            // egnLabel
            // 
            egnLabel.AutoSize = true;
            egnLabel.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            egnLabel.ForeColor = Color.MidnightBlue;
            egnLabel.Location = new Point(9, 92);
            egnLabel.Name = "egnLabel";
            egnLabel.Size = new Size(52, 22);
            egnLabel.TabIndex = 7;
            egnLabel.Text = "EGN";
            // 
            // egnTextBox
            // 
            egnTextBox.BackColor = Color.WhiteSmoke;
            egnTextBox.Cursor = Cursors.Hand;
            egnTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            egnTextBox.ForeColor = Color.Gray;
            egnTextBox.Location = new Point(39, 128);
            egnTextBox.Name = "egnTextBox";
            egnTextBox.Size = new Size(197, 26);
            egnTextBox.TabIndex = 8;
            egnTextBox.Text = "1234567890";
            egnTextBox.Enter += egnTextBox_Enter;
            egnTextBox.Leave += egnTextBox_Leave;
            // 
            // maleRadioBtn
            // 
            maleRadioBtn.AutoSize = true;
            maleRadioBtn.Cursor = Cursors.Hand;
            maleRadioBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maleRadioBtn.Location = new Point(39, 40);
            maleRadioBtn.Name = "maleRadioBtn";
            maleRadioBtn.RightToLeft = RightToLeft.No;
            maleRadioBtn.Size = new Size(63, 22);
            maleRadioBtn.TabIndex = 11;
            maleRadioBtn.TabStop = true;
            maleRadioBtn.Text = "Male";
            maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            femaleRadioBtn.AutoSize = true;
            femaleRadioBtn.Cursor = Cursors.Hand;
            femaleRadioBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            femaleRadioBtn.Location = new Point(204, 40);
            femaleRadioBtn.Name = "femaleRadioBtn";
            femaleRadioBtn.RightToLeft = RightToLeft.No;
            femaleRadioBtn.Size = new Size(83, 22);
            femaleRadioBtn.TabIndex = 12;
            femaleRadioBtn.TabStop = true;
            femaleRadioBtn.Text = "Female";
            femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(insuranceNumberTextBox);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(backBtn);
            groupBox1.Controls.Add(maleRadioBtn);
            groupBox1.Controls.Add(femaleRadioBtn);
            groupBox1.Controls.Add(insuranceNumberLabel);
            groupBox1.Controls.Add(egnLabel);
            groupBox1.Controls.Add(egnTextBox);
            groupBox1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(353, 510);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(336, 371);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // insuranceNumberTextBox
            // 
            insuranceNumberTextBox.BackColor = Color.WhiteSmoke;
            insuranceNumberTextBox.Cursor = Cursors.Hand;
            insuranceNumberTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insuranceNumberTextBox.ForeColor = Color.Gray;
            insuranceNumberTextBox.Location = new Point(39, 221);
            insuranceNumberTextBox.Name = "insuranceNumberTextBox";
            insuranceNumberTextBox.RightToLeft = RightToLeft.No;
            insuranceNumberTextBox.Size = new Size(197, 26);
            insuranceNumberTextBox.TabIndex = 17;
            insuranceNumberTextBox.Text = "1234567890";
            insuranceNumberTextBox.TextChanged += insuranceNumberTextBox_TextChanged;
            insuranceNumberTextBox.Enter += insuranceNumberTextBox_Enter;
            insuranceNumberTextBox.Leave += insuranceNumberTextBox_Leave;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.MidnightBlue;
            addBtn.Location = new Point(39, 299);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 38);
            addBtn.TabIndex = 17;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.MidnightBlue;
            backBtn.Location = new Point(204, 299);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 38);
            backBtn.TabIndex = 18;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // insuranceNumberLabel
            // 
            insuranceNumberLabel.AutoSize = true;
            insuranceNumberLabel.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insuranceNumberLabel.ForeColor = Color.MidnightBlue;
            insuranceNumberLabel.Location = new Point(9, 180);
            insuranceNumberLabel.Name = "insuranceNumberLabel";
            insuranceNumberLabel.Size = new Size(201, 22);
            insuranceNumberLabel.TabIndex = 17;
            insuranceNumberLabel.Text = "Insurance Number";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryLabel.ForeColor = Color.MidnightBlue;
            CountryLabel.Location = new Point(7, 270);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(90, 22);
            CountryLabel.TabIndex = 15;
            CountryLabel.Text = "Country";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 821);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 26);
            comboBox1.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BirthdateCalendar);
            groupBox2.Controls.Add(CountryLabel);
            groupBox2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(12, 510);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(344, 371);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Birthdate";
            // 
            // BirthdateCalendar
            // 
            BirthdateCalendar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthdateCalendar.Location = new Point(39, 40);
            BirthdateCalendar.Name = "BirthdateCalendar";
            BirthdateCalendar.TabIndex = 19;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 877);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lastNameTextBox);
            Controls.Add(secondNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(PersonalInfoLabel);
            Controls.Add(RegisterPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Agency";
            Load += RegisterForm_Load;
            Enter += RegisterForm_Enter;
            ((System.ComponentModel.ISupportInitialize)RegisterPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RegisterPictureBox;
        private Label PersonalInfoLabel;
        private TextBox firstNameTextBox;
        private TextBox secondNameTextBox;
        private TextBox lastNameTextBox;
        private Label egnLabel;
        private TextBox egnTextBox;
        private RadioButton maleRadioBtn;
        private RadioButton femaleRadioBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label CountryLabel;
        private ComboBox comboBox1;
        private TextBox insuranceNumberTextBox;
        private Label insuranceNumberLabel;
        private Button addBtn;
        private Button backBtn;
        private MonthCalendar BirthdateCalendar;
    }
}