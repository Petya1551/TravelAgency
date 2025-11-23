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
            RegisterPictureBox = new PictureBox();
            PersonalInfoLabel = new Label();
            firstNameTextBox = new TextBox();
            secondNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            birthdateLabel = new Label();
            birthdateTextBox = new TextBox();
            egnLabel = new Label();
            egnTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RegisterPictureBox).BeginInit();
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
            PersonalInfoLabel.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonalInfoLabel.ForeColor = Color.MidnightBlue;
            PersonalInfoLabel.Location = new Point(29, 405);
            PersonalInfoLabel.Name = "PersonalInfoLabel";
            PersonalInfoLabel.Size = new Size(216, 20);
            PersonalInfoLabel.TabIndex = 1;
            PersonalInfoLabel.Text = "Personal Contact Info";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.Linen;
            firstNameTextBox.Cursor = Cursors.Hand;
            firstNameTextBox.ForeColor = Color.Gray;
            firstNameTextBox.Location = new Point(19, 442);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(197, 27);
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.Text = "First Name";
            firstNameTextBox.Enter += firstNameTextBox_Enter;
            firstNameTextBox.Leave += firstNameTextBox_Leave;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.BackColor = Color.Linen;
            secondNameTextBox.Cursor = Cursors.Hand;
            secondNameTextBox.ForeColor = Color.Gray;
            secondNameTextBox.Location = new Point(249, 442);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.Size = new Size(197, 27);
            secondNameTextBox.TabIndex = 3;
            secondNameTextBox.Text = "Second Name";
            secondNameTextBox.Enter += secondNameTextBox_Enter;
            secondNameTextBox.Leave += secondNameTextBox_Leave;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.Linen;
            lastNameTextBox.Cursor = Cursors.Hand;
            lastNameTextBox.ForeColor = Color.Gray;
            lastNameTextBox.Location = new Point(480, 442);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(197, 27);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.Text = "Last Name";
            lastNameTextBox.Enter += lastNameTextBox_Enter;
            lastNameTextBox.Leave += lastNameTextBox_Leave;
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthdateLabel.ForeColor = Color.MidnightBlue;
            birthdateLabel.Location = new Point(29, 501);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new Size(98, 20);
            birthdateLabel.TabIndex = 5;
            birthdateLabel.Text = "Birthdate";
            // 
            // birthdateTextBox
            // 
            birthdateTextBox.BackColor = Color.Linen;
            birthdateTextBox.Cursor = Cursors.Hand;
            birthdateTextBox.ForeColor = Color.Gray;
            birthdateTextBox.Location = new Point(19, 535);
            birthdateTextBox.Name = "birthdateTextBox";
            birthdateTextBox.Size = new Size(197, 27);
            birthdateTextBox.TabIndex = 6;
            birthdateTextBox.Text = "MM/DD/YYYY";
            birthdateTextBox.Enter += birthdateTextBox_Enter;
            birthdateTextBox.Leave += birthdateTextBox_Leave;
            // 
            // egnLabel
            // 
            egnLabel.AutoSize = true;
            egnLabel.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            egnLabel.ForeColor = Color.MidnightBlue;
            egnLabel.Location = new Point(609, 501);
            egnLabel.Name = "egnLabel";
            egnLabel.Size = new Size(49, 20);
            egnLabel.TabIndex = 7;
            egnLabel.Text = "EGN";
            // 
            // egnTextBox
            // 
            egnTextBox.BackColor = Color.Linen;
            egnTextBox.Cursor = Cursors.Hand;
            egnTextBox.ForeColor = Color.Gray;
            egnTextBox.Location = new Point(480, 535);
            egnTextBox.Name = "egnTextBox";
            egnTextBox.Size = new Size(197, 27);
            egnTextBox.TabIndex = 8;
            egnTextBox.Text = "1234567890";
            egnTextBox.Enter += egnTextBox_Enter;
            egnTextBox.Leave += egnTextBox_Leave;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 895);
            Controls.Add(egnTextBox);
            Controls.Add(egnLabel);
            Controls.Add(birthdateTextBox);
            Controls.Add(birthdateLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(secondNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(PersonalInfoLabel);
            Controls.Add(RegisterPictureBox);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)RegisterPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RegisterPictureBox;
        private Label PersonalInfoLabel;
        private TextBox firstNameTextBox;
        private TextBox secondNameTextBox;
        private TextBox lastNameTextBox;
        private Label birthdateLabel;
        private TextBox birthdateTextBox;
        private Label egnLabel;
        private TextBox egnTextBox;
    }
}